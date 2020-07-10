using System;
using System.Collections.Generic;

namespace OnlineStore.DataAccess.Models
{
    public partial class Address
    {
        public long CustomerId { get; set; }
        public string Address1 { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
