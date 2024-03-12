using System.ComponentModel.DataAnnotations;

namespace CineRateHub.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(60, MinimumLength = 3)]
        public required string Name { get; set; }

        [Range(1, 100)]
        public int Age { get; set; }

        public string? Job { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(50, ErrorMessage = "Must be between 5 and 50 characters.", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters.", MinimumLength = 5)]
        public string Password { get; set; } = null!;
    }
}
