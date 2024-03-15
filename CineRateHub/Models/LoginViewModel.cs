using System.ComponentModel.DataAnnotations;

namespace CineRateHub.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "An email is needed")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "An password is needed")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

    }
}
