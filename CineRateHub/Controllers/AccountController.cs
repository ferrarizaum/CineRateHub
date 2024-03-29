﻿using CineRateHub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CineRateHub.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager,
                                 SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager; 
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid) 
            {
                var user = new User
                { 
                    UserName = model.Email, 
                    Email = model.Email 
                };    
                //review nullable types
                var result = await userManager.CreateAsync(user, model.Password!);

                if (result.Succeeded) 
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "home");
                }

                foreach (var error in result.Errors) 
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {   //review nullable types
                var result = await signInManager.PasswordSignInAsync(model.Email!, model.Password!, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "home");
        }
    }
}
