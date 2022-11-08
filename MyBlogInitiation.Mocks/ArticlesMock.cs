using MyBlogInitiation.Models;

namespace MyBlogInitiation.Mocks
{
    public static class ArticlesMock
    {
        public static List<ArticleModel> listArticles = new List<ArticleModel>
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
            };
    }
}