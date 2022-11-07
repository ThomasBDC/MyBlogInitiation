using Microsoft.AspNetCore.Mvc;
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
                Articles = new List<ArticleModel>
                {
                    new ArticleModel
                    {
                        Id =0,
                        Title = "Les objets connectés en 2022",
                        Content = "...",
                        Available = true
                    },
                    new ArticleModel
                    {
                        Id =1,
                        Title = "Les objets connectés en 2023",
                        Content = "...",
                        Available = true
                    },
                    new ArticleModel
                    {
                        Id =2,
                        Title = "Les objets connectés en 2024",
                        Content = "...",
                        Available = false
                    }
                }
            };

            return View(vm);
        }
    }
}
