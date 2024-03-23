using System.ComponentModel.DataAnnotations;

namespace CineRateHub.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string? Title { get; set; }
        
        public DateTime ReleaseDate { get; set; }
       
        public string? Genre { get; set; }

        public string? Director { get; set; }

        public decimal? Rating { get; set; }

        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
 