//using OnlineStore.Common.DTO;
using OnlineStore.DataAccess.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.DataAccess.Reposotories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        //IEnumerable GetAll();
        
        /// <summary>
        /// Get customer details by customer email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Customer GetCustomerByEmail(string email);
    }
}
