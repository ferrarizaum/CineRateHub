using CineRateHub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CineRateHub.Data
{
    public class CineRateHubContext : IdentityDbContext
    {
        public CineRateHubContext(DbContextOptions<CineRateHubContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<User> User { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Avatar", ReleaseDate = DateTime.Parse("2009-12-18"), Genre = "Action", Director = "James Cameron", Rating = 7.9M },
                new Movie { Id = 2, Title = "300", ReleaseDate = DateTime.Parse("2007-03-09"), Genre = "Action", Director = "Zack Snyder", Rating = 7.7M },
                new Movie { Id = 3, Title = "The Wolf of Wall Street", ReleaseDate = DateTime.Parse("2013-12-25"), Genre = "Biography", Director = "Martin Scorsese", Rating = 8.2M },
                new Movie { Id = 4, Title = "Interstellar", ReleaseDate = DateTime.Parse("2014-11-07"), Genre = "Adventure", Director = "Christopher Nolan", Rating = 8.6M }

            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Jose Carlos Ferrari", Age= 22, Job = "Fullstack Developer", Email = "joseferrari17@hotmail.com", Password = "coxinha123" },
                new User { Id = 2, Name = "Hernandes Zanella", Age = 23, Job = "Agronomist", Email = "hernandeszanella@hotmail.com", Password = "coxinha123" },
                new User {Id = 3, Name = "Leonardo Araujo", Age = 23, Job = "Agronomist", Email = "leoaraujo@hotmail.com", Password = "coxinha123" },
                new User {Id = 4, Name = "Juca", Age = 21, Job = "Unemployed", Email = "jucabala123@hotmail.com", Password = "coxinha123" }
            );
        }
    }
}
