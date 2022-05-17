using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactBlogSite.Data;

namespace ReactBlogSite.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private string _connectionString;
        public BlogPostController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConStr");
        }

        [HttpGet]
        [Route("getall")]
        public List<BlogPost> GetAll()
        {
            var repo = new BlogPostRepo(_connectionString);
            return repo.GetBlogPosts();
        }

        [HttpPost]
        [Route("AddBlogPost")]

        public void AddPost(BlogPost blogPost)
        {
            blogPost.DateCreated = DateTime.Now;
            var repo = new BlogPostRepo(_connectionString);
            repo.AddBlog(blogPost);
        }

        [HttpPost]
        [Route("AddComment")]
        public void AddComment(Comment comment)
        {
            comment.DateCommented = DateTime.Now;
            var repo = new BlogPostRepo(_connectionString);
            repo.AddComment(comment);
        }

        [HttpGet]
        [Route("GetBlogById")]
        public BlogPost GetBlogPost (int id)
        {
            var repo = new BlogPostRepo(_connectionString);
            return repo.GetById(id);
        }


    }
}
