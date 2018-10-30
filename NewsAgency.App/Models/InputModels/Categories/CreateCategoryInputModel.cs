using System.ComponentModel.DataAnnotations;

namespace NewsAgency.App.Models.InputModels.Categories
{
    public class CreateCategoryInputModel
    {
        [Required]
        [StringLength(maximumLength:200,MinimumLength = 3)]
        public string Name { get; set; }
    }
}