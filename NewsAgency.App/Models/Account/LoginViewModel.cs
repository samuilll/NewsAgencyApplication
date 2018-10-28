using System.ComponentModel.DataAnnotations;

namespace NewsAgency.App.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        [StringLength(maximumLength:20,MinimumLength = 3)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}