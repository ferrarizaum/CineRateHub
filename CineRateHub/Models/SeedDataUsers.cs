using CineRateHub.Data;
using Microsoft.EntityFrameworkCore;

namespace CineRateHub.Models
{
    public class SeedDataUsers
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var _userContext = new UserContext(serviceProvider.GetRequiredService<DbContextOptions<UserContext>>()))
            {
                if (_userContext.User.Any())
                {
                    return;
                }
                _userContext.User.AddRange(
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
                _userContext.SaveChanges();
            }

        }

    }
}
