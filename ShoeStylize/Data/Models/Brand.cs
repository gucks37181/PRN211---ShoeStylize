using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Shoes = new HashSet<Shoe>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<Shoe> Shoes { get; set; }
    }
}
