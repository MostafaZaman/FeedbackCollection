using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackCollection.Models
{
    public class FeedbackViewModel
    {
        public int id { get; set; }
        public string Vote { get; set; }
        public string PostTitle { get; set; }
        public DateTime? CreationTime { get; set; }
        public string UserName { get; set; }

    }
}
