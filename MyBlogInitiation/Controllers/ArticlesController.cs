using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlogInitiation.Mocks;
using MyBlogInitiation.Models;
using MyBlogInitiation.Repository.Context;

namespace MyBlogInitiation.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly DbBlogContext _dbBlogContext;
        public ArticlesController(DbBlogContext dbBlogContext)
        {
            _dbBlogContext = dbBlogContext;
        }

        public async Task<IActionResult> Index()
        {
            //Créer une liste d'article EN DUR
            var vm = new ArticlesViewModel
            {
                Articles = await _dbBlogContext.Articles.ToListAsync()
            };

            return View(vm);
        }


    }
}
