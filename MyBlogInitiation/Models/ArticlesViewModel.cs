namespace MyBlogInitiation.Models
{
    //Une classe que je veux donner à la vue
    public class ArticlesViewModel
    {
        public List<ArticleModel> Articles { get; set; }
    }


    //Une classe identique à ma table en BDD
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Available { get; set; }
    }
}
