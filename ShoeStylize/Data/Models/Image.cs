using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Image
    {
        public int ImageId { get; set; }
        public int CusShoeId { get; set; }
        public string ImageLink { get; set; }

        public virtual CustomizeShoe CusShoe { get; set; }
    }
}
