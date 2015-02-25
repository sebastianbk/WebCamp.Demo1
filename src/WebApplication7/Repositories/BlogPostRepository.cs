using System;
using WebApplication7.Models;

namespace WebApplication7.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        public BlogPostRepository()
        {
            var x = 5;
        }

        public BlogPost GetBlogPost()
        {
            var blogPost = new BlogPost
            {
                Id = 1,
                Title = "ASP.NET 5 er megasejt!",
                Content = "Visual Studio er bare det fedeste!"
            };

            return blogPost;
        }
    }
}