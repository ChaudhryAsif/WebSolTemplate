using DAL.DbContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MultiTanet.Models;

namespace MultiTanet.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationUserDbContext _dbContext;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AccountController(ApplicationUserDbContext context, SignInManager<IdentityUser> signInManager)
        {
            _dbContext = context;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult LogIn(string returnUrl)
        {
            if (User != null && User.Identity != null && User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            //Logout();
            ViewBag.ReturnUrl = returnUrl;
            return View(new LogInViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LogInViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

            return View();
        }
    }
}
