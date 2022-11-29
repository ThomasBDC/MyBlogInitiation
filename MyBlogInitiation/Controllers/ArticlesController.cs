using Microsoft.AspNetCore.Mvc;
using MyBlogInitiation.Mocks;
using MyBlogInitiation.Models;
using MyBlogInitiation.Repository.DAL;

namespace MyBlogInitiation.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly ArticlesPublicDAL _articlesPublicRepository;
        public ArticlesController(ArticlesPublicDAL articlesPublicRepository)
        {
            _articlesPublicRepository = articlesPublicRepository;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new ArticlesViewModel
            {
                Articles = await _articlesPublicRepository.GetAllArticles()
            };

            return View(vm);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articleModel = await _articlesPublicRepository.GetArticle(id.Value);

            if (articleModel == null || !articleModel.Available)
            {
                return NotFound();
            }

            return View(articleModel);
        }

    }
}
