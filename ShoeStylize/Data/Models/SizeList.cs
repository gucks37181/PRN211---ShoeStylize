using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class SizeList
    {
        public SizeList()
        {
            Shoes = new HashSet<Shoe>();
        }

        public int SizeId { get; set; }
        public string Size { get; set; }

        public virtual ICollection<Shoe> Shoes { get; set; }
    }
}
