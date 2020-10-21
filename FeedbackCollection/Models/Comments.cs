using System;
using System.Collections.Generic;

namespace FeedbackCollection.Models
{
    public partial class Comments
    {
        public int CommentId { get; set; }
        public string CommentName { get; set; }
        public int PostId { get; set; }
        public string Vote { get; set; }

        public virtual Posts Post { get; set; }
    }
}
