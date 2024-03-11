using CineRateHub.Models;
using Microsoft.EntityFrameworkCore;

namespace CineRateHub.Data
{
    public class CineRateHubContext : DbContext
    {
        public CineRateHubContext(DbContextOptions<CineRateHubContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<User> User { get; set; } = default!;
    }
}
