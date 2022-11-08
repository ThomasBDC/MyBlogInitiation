using Microsoft.AspNetCore.Mvc;
using MyBlogInitiation.Mocks;
using MyBlogInitiation.Models;

namespace MyBlogInitiation.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult Index()
        {
            //Créer une liste d'article EN DUR
            var vm = new ArticlesViewModel
            {
                Articles = ArticlesMock.listArticles
            };

            return View(vm);
        }
    }
}
