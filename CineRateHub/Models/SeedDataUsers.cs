using CineRateHub.Data;
using Microsoft.EntityFrameworkCore;

namespace CineRateHub.Models
{
    public class SeedDataUsers
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var _cineRateHubContext = new CineRateHubContext(serviceProvider.GetRequiredService<DbContextOptions<CineRateHubContext>>()))
            {
                if (_cineRateHubContext.User.Any())
                {
                    return;
                }
                _cineRateHubContext.User.AddRange(
                    new User
                    {
                        Name = "Jose Carlos Ferrari",
                        Age = 22,
                        Job = "Fullstack Developer",
                    },
                    new User
                    {
                        Name = "Hernandes Zanella",
                        Age = 23,
                        Job = "Agronomist",
                    },
                    new User
                    {
                        Name = "Leonardo Araujo",
                        Age = 23,
                        Job = "Agronomist",
                    },
                     new User
                     {
                         Name = "Juca",
                         Age = 21,
                         Job = "Unemployed",
                     }
                    );
                _cineRateHubContext.SaveChanges();
            }

        }

    }
}
