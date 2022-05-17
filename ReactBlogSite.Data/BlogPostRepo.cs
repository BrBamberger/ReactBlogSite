using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactBlogSite.Data
{
    public class BlogPostRepo
    {
        private string _connectionString;
        public BlogPostRepo(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<BlogPost> GetBlogPosts()
        {
            using var context = new BlogPostDataContext(_connectionString);
            return context.BlogPosts.Include(b => b.Comments).ToList();
        }

        public void AddBlog(BlogPost blogpost)
        {
            using var context = new BlogPostDataContext(_connectionString);
            context.BlogPosts.Add(blogpost);
            context.SaveChanges();
        }

        public void AddComment(Comment comment)
        {
            using var context = new BlogPostDataContext(_connectionString);
            context.Comments.Add(comment);
            context.SaveChanges();
        }

        public List<Comment> GetComments(int blogId)
        {
            using var context = new BlogPostDataContext(_connectionString);
            return context.Comments.Where(c => c.BlogPostId == blogId).ToList();
        }

        public BlogPost GetById (int blogId)
        {
            using var context = new BlogPostDataContext(_connectionString);
            return context.BlogPosts.FirstOrDefault(b => b.Id == blogId);
        }
    }
}
