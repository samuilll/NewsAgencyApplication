using System.ComponentModel.DataAnnotations;

namespace NewsAgency.App.Models.InputModels.Articles
{
    public class EditArticleInputModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 200, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [StringLength(maximumLength: 5000, MinimumLength = 3)]
        public string Content { get; set; }
    }
}