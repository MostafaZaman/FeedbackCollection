using System;
using System.Collections.Generic;

namespace FeedbackCollection.Models
{
    public partial class User
    {
        public User()
        {
            Posts = new HashSet<Posts>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }
    }
}
