using CineRateHub.Data;
using Microsoft.EntityFrameworkCore;

namespace CineRateHub.Models
{
    public class SeedDataMovies
    {
        //remove price fields, change field type for rating to decimal and add director field and others
        public static void Initialize(IServiceProvider serviceProvider) 
        {
            using (var _movieContext = new MovieContext(serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>()))
            {
                if(_movieContext.Movie.Any()) 
                {
                    return;
                }
                _movieContext.Movie.AddRange(
                    new Movie
                    { 
                        Title = "Avatar",
                        ReleaseDate = DateTime.Parse("2009-12-18"),
                        Genre = "Action",
                        Rating = "7.9M",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "300",
                        ReleaseDate = DateTime.Parse("2007-03-09"),
                        Genre = "Action",
                        Rating = "7.7M",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "The Wolf of Wall Street",
                        ReleaseDate = DateTime.Parse("2013-12-25"),
                        Genre = "Biography",
                        Rating = "8.2M",
                        Price = 7.99M
                    },
                     new Movie
                     {
                         Title = "Interstellar",
                         ReleaseDate = DateTime.Parse("2014-11-07"),
                         Genre = "Adventure",
                         Rating = "8.6M",
                         Price = 7.99M
                     }
                    );
                _movieContext.SaveChanges();
            }
        
        }

    }
}
