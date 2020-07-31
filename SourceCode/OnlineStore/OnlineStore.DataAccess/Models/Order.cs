using System;
using System.Collections.Generic;

namespace OnlineStore.DataAccess.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public long OrderId { get; set; }
        public double? Amount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string ShippingMethod { get; set; }
        public string Status { get; set; }
        public string OrderNote { get; set; }
        public long CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
