using System;
using WebApplication7.Models;

namespace WebApplication7.Repositories
{
    public interface IBlogPostRepository
    {
        BlogPost GetBlogPost();
    }
}