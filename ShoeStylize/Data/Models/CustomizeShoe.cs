using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class CustomizeShoe
    {
        public CustomizeShoe()
        {
            Images = new HashSet<Image>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int CusShoeId { get; set; }
        public int? ShoeId { get; set; }
        public int? UserId { get; set; }
        public string ShoesName { get; set; }
        public string CustomizationDetails { get; set; }

        public virtual Shoe Shoe { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
