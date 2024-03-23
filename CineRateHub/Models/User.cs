using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CineRateHub.Models
{
    public class User : IdentityUser
    {
        public string? Name { get; set; }

        public int? Age { get; set; }

        public string? Job { get; set; }

       
    }
}
