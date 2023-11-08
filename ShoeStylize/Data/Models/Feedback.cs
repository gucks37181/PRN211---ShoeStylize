using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public string FeedbackType { get; set; }
        public int? UserId { get; set; }
        public int? ShoeId { get; set; }
        public string Title { get; set; }
        public int? Rating { get; set; }
        public string Content { get; set; }

        public virtual Shoe Shoe { get; set; }
        public virtual User User { get; set; }
    }
}
