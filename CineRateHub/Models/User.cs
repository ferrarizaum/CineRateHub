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
    }
}
