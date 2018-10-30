using System.ComponentModel;

namespace NewsAgency.App.Models.DisplayModels.Authors
{
    public class AuthorViewModel
    {
        [DisplayName("Author")] public string Username { get; set; }
    }
}