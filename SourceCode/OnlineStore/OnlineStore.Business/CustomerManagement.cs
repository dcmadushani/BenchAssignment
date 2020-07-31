using AutoMapper;
using OnlineStore.Business.Interface;
using OnlineStore.Common.DTO;
using OnlineStore.Common.Logging;
using OnlineStore.DataAccess.Models;
using OnlineStore.DataAccess.Reposotories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Business
{
    public class CustomerManagement: ICustomerManagement
    {
        private readonly OnlineStoreDbContext db;
        private ICustomerRepository customerRepository;
        private readonly IMapper _mapper;
        private LoggingManager logger = new LoggingManager();

        public CustomerManagement()
        {
            db = new OnlineStoreDbContext();

        }

        /// <summary>
        /// Create object from customer repository
        /// </summary>
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (this.customerRepository == null)
                {
                    this.customerRepository = new CustomerRepository(db);
                }
                return this.customerRepository;
            }
        }

        /// <summary>
        /// Get customer details by customer email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Customer GetCustomerByEmail(string email)
        {
            Customer customerData = new Customer();
            try
            {
                customerData = CustomerRepository.GetCustomerByEmail(email);
                //CustomerDto resut = customerData != null ? _mapper.Map<CustomerDto>(customerData) : null;
                //return resut;
                //return customerData;
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
            return customerData;
        }

    }
}
