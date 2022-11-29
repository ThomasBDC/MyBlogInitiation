using Microsoft.EntityFrameworkCore;
using MyBlogInitiation.Models;
using MyBlogInitiation.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogInitiation.Repository.DAL
{
    //Cette classe va servir d'intermédiaire entre l'appli web et Entity
    //APPWEB -> Repository -> Entity -> BDD
    public class ArticlesPublicDAL
    {
        private readonly DbBlogContext _context;

        public ArticlesPublicDAL(DbBlogContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retourne un article en fonction de son ID si il est available
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ArticleModel> GetArticle(int id)
        {
            var articleModel = await _context.Articles.FirstOrDefaultAsync(article => article.Id == id && article.Available == true);

            return articleModel;
        }

        public async Task<List<ArticleModel>> GetAllArticles()
        {
            return await _context.Articles.Where(article => article.Available == true).ToListAsync();
        }

    }
}
