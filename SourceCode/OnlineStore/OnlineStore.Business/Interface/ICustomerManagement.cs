using OnlineStore.Common.DTO;
using OnlineStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Business.Interface
{
    public interface ICustomerManagement
    {
        Customer GetCustomerByID(string email);
    }
}
