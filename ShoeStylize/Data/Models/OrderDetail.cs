using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? ShoeId { get; set; }
        public int? CusShoeId { get; set; }
        public bool? Status { get; set; }
        public int? Quantity { get; set; }

        public virtual CustomizeShoe CusShoe { get; set; }
        public virtual Order Order { get; set; }
        public virtual Shoe Shoe { get; set; }
    }
}
