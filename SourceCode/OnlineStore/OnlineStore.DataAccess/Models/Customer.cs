using System;
using System.Collections.Generic;

namespace OnlineStore.DataAccess.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Address = new HashSet<Address>();
        }

        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? RegistedDate { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
