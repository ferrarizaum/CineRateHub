using CineRateHub.Data;
using Microsoft.EntityFrameworkCore;

namespace CineRateHub.Models
{
    public class SeedDataMovies
    {
        public static void Initialize(IServiceProvider serviceProvider) 
        {
            using (var _cineRateHubContext = new CineRateHubContext(serviceProvider.GetRequiredService<DbContextOptions<CineRateHubContext>>()))  
            {
                if(_cineRateHubContext.Movie.Any()) 
                {
                    return;
                }
                _cineRateHubContext.Movie.AddRange(
                    new Movie
                    { 
                        Title = "Avatar",
                        ReleaseDate = DateTime.Parse("2009-12-18"),
                        Genre = "Action",
                        Director = "James Cameron",
                        Rating = 7.9M,
                        
                    },
                    new Movie
                    {
                        Title = "300",
                        ReleaseDate = DateTime.Parse("2007-03-09"),
                        Genre = "Action",
                        Director = "Zack Snyder",
                        Rating = 7.7M,
                        
                    },
                    new Movie
                    {
                        Title = "The Wolf of Wall Street",
                        ReleaseDate = DateTime.Parse("2013-12-25"),
                        Genre = "Biography",
                        Director = "Martin Scorsese",
                        Rating = 8.2M,
                        
                    },
                     new Movie
                     {
                         Title = "Interstellar",
                         ReleaseDate = DateTime.Parse("2014-11-07"),
                         Genre = "Adventure",
                         Director = "Christopher Nolan",
                         Rating = 8.6M,
                        
                     }
                    );
                _cineRateHubContext.SaveChanges();
            }
        
        }

    }
}
