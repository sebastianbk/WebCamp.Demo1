using Microsoft.AspNet.Mvc;
using WebApplication7.Repositories;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        private IBlogPostRepository repo;

        public HomeController(IBlogPostRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var blogPost = repo.GetBlogPost();

            return View(blogPost);
        }
    }
}
