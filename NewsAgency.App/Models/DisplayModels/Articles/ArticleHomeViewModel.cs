using NewsAgency.App.Models.DisplayModels.Authors;

namespace NewsAgency.App.Models.DisplayModels.Articles
{
    public class ArticleHomeViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorViewModel Author { get; set; }
    }
}