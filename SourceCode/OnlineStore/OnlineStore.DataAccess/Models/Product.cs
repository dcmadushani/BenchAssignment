using System;
using System.Collections.Generic;

namespace OnlineStore.DataAccess.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public string Category { get; set; }

        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
