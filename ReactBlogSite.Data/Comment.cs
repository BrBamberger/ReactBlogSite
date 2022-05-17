using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ReactBlogSite.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateCommented { get; set; }
        public string Commentor { get; set; }
        public int BlogPostId { get; set; }
        

        [JsonIgnore]
        public BlogPost BlogPost { get; set; }
    }
}
