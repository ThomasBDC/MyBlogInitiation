using Microsoft.AspNetCore.Mvc;

namespace MyBlogInitiation.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
