using CineRateHub.Models;
using Microsoft.AspNetCore.Identity;

namespace CineRateHub.Services
{
    public class SeedUserRoleInitial : ISeedUserRoleInitial
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedUserRoleInitial(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        //way of seeding role data to db if they dont exist
        public async Task SeedRolesAsync()
        {
            if(! await _roleManager.RoleExistsAsync("User"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                role.NormalizedName = "USER";
                role.ConcurrencyStamp = Guid.NewGuid().ToString(); 

                IdentityResult roleResult = await _roleManager.CreateAsync(role);
            }

            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                role.NormalizedName = "ADMIN";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();

                IdentityResult roleResult = await _roleManager.CreateAsync(role);
            }
        }
        //new way of seeding data to sql server db
        public async Task SeedUsersAsync()
        {
            if(await _userManager.FindByEmailAsync("user@gmail.com") == null)
            {
                User user = new User();
                user.UserName = "user@gmail.com";
                user.Email = "user@gmail.com";
                user.NormalizedUserName = "USER@GMAIL.COM";
                user.NormalizedEmail = "USER@GMAIL.COM";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();
                user.Name = "User";
                user.Age = 22;
                user.Job = "FullStackDev";

                IdentityResult result = await _userManager.CreateAsync(user, "Numsey#2024");

                if(!result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                }
            }

            if (await _userManager.FindByEmailAsync("admin@gmail.com") == null)
            {
                User user = new User();
                user.UserName = "admin@gmail.com";
                user.Email = "admin@gmail.com";
                user.NormalizedUserName = "ADMIN@GMAIL.COM";
                user.NormalizedEmail = "ADMIN@GMAIL.COM";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();
                user.Name = "Admin";
                user.Age = 22;
                user.Job = "FullStackDev";

                IdentityResult result = await _userManager.CreateAsync(user, "Numsey#2024");

                if (!result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }
    }
}
