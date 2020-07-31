using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OnlineStore.Business;
using OnlineStore.Common.DTO;
using OnlineStore.DataAccess.Models;

namespace OnlineStore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IConfiguration _config;
        private IMapper _mapper;
        private CustomerManagement customerManagement = new CustomerManagement();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="config"></param>
        public CustomerController(IConfiguration config, IMapper mapper)
        {
            _config = config;
            _mapper = mapper;
        }

        //private CustomerManagement customerManagement = new CustomerManagement(mapper);

        /// <summary>
        /// Login customers
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login(string username, string password)
        {
            CustomerDto login = new CustomerDto();
            login.UserName = username;
            login.Password = password;
            IActionResult response = Unauthorized();

            var user = AuthenticateUser(login);

            if (user != null)
            {
                var tokenStr = GenerateJsonWebToken(user);
                response = Ok(new { token = tokenStr });
            }

            return response;
        }

        /// <summary>
        /// Authenticate user
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private CustomerDto AuthenticateUser(CustomerDto login)
        {
            CustomerDto customer = null;
            if (login.UserName == "test" && login.Password == "123")
            {
                customer = new CustomerDto { UserName = "test", Email = "test@gmail.com", Password = "123" };

            }
            return customer;
        }
        
        /// <summary>
        /// Jenerate JWT for autherization
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        private string GenerateJsonWebToken(CustomerDto userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,userInfo.UserName),
                new Claim(JwtRegisteredClaimNames.Email,userInfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            var encodeToken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodeToken;
        }

        //[Authorize]
        [HttpPost("Post")]
        public string Post()
        {
            //var identity = HttpContext.User.Identity as ClaimsIdentity;
            //IList<Claim> claim = identity.Claims.ToList();
            //var userName = claim[0].Value;
            //return "Welcome to : " + userName;
            return "Welcome to OnlineStore";
        }

        //[Authorize]
        [HttpGet("GatValue")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Value1", "Value2", "Value3" };
        }

        [HttpGet("GetCustomer")]
        public CustomerDto GetCustomerByID(string email)
         {
            var customerData = customerManagement.GetCustomerByID(email);
            CustomerDto result = customerData != null ? _mapper.Map<CustomerDto>(customerData) : null;
            return result;
            //return customerManagement.GetCustomerByID(email);

        }
    }
}