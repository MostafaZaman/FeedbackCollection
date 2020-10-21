using System;
using System.Collections.Generic;

namespace FeedbackCollection.Models
{
    public partial class Posts
    {
        public Posts()
        {
            Comments = new HashSet<Comments>();
        }

        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public int UserId { get; set; }
        public DateTime? CreationTime { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
