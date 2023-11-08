using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Shoe
    {
        public Shoe()
        {
            Comments = new HashSet<Comment>();
            CustomizeShoes = new HashSet<CustomizeShoe>();
            Feedbacks = new HashSet<Feedback>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ShoeId { get; set; }
        public int? BrandId { get; set; }
        public string ShoesName { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? SizeId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual SizeList SizeNavigation { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<CustomizeShoe> CustomizeShoes { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
