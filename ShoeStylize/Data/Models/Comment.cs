using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int? UserId { get; set; }
        public int? ShoeId { get; set; }
        public string Content { get; set; }

        public virtual Shoe Shoe { get; set; }
        public virtual User User { get; set; }
    }
}
