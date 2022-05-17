using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ReactBlogSite.Data
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public string Author { get; set; }
        public List <Comment> Comments { get; set; }
    }
}
