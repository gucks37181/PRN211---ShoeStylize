using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class BlogPost
    {
        public int PostId { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? PostDay { get; set; }

        public virtual User User { get; set; }
    }
}
