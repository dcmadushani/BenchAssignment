using System;
using System.Collections.Generic;

namespace OnlineStore.DataAccess.Models
{
    public partial class OrderProduct
    {
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public int? NoOfUnits { get; set; }
        public double? UnitPrice { get; set; }
        public string Status { get; set; }
    }
}
