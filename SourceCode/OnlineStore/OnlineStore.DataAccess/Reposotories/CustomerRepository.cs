using OnlineStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
//using OnlineStore.Common.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;
using AutoMapper;

namespace OnlineStore.DataAccess.Reposotories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        //private OnlineStoreDbContext context;
        //private IRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;

        public OnlineStoreDbContext context
        {
            get
            {
                return db as OnlineStoreDbContext;
            }
        }

        public CustomerRepository(OnlineStoreDbContext _db) 
            : base(_db)
        {

        }

        public Customer GetCustomerByID(string email)
        {
            Customer customer = context.Customer.Where(c => c.Email == email).FirstOrDefault();
            //customer.Address = context.Address.Where(a => a.CustomerId == customer.CustomerId).ToList();
            //CustomerDto result = new CustomerDto
            //{
            //    CustomerId = customer.CustomerId,
            //    FirstName = customer.FirstName,
            //    LastName = customer.LastName,
            //    Email = customer.Email,
            //    Phone = customer.Phone,
            //    //CustomerAddress = customer.Address,
            //    RegistedDate = customer.RegistedDate,
            //    UserName = customer.UserName,
            //    Password = customer.Password
            //}; 
            //CustomerDto result = customer != null ?_mapper.Map<CustomerDto>(customer) : null;
            //return result;
            return customer;
           
        }
    }
}
