using System.ComponentModel.DataAnnotations;

namespace NewsAgency.App.Models.InputModels.Account
{
    public class LoginInputModel
    {
        [Required]
        [Display(Name = "Username")]
        [StringLength(maximumLength: 20, MinimumLength = 3)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(maximumLength: 30, MinimumLength = 3)]
        public string Password { get; set; }
    }
}