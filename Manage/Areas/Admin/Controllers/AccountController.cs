using System.Threading.Tasks;
using Core;
using Core.Models;
using Data;
using Manage.Areas.Admin.Models.ViewModels;
using Manage.Attributes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Manage.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly IUnitOfWork unitOfWork;

        public AccountController(SignInManager<User> signInManager,
            UserManager<User> userManager, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [AnonymousOnly]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AnonymousOnly]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return LocalRedirect(returnUrl);
                    else
                        return RedirectToAction("index", "home");
                }
                else
                    ModelState.AddModelError(string.Empty, "Username or Password are incorrect!");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("login", "account", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult Change_Password()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Change_Password(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.GetUserAsync(User);
                if (user != null)
                {
                    var hasher = new PasswordHasher<User>();

                    var isCorrect = hasher.VerifyHashedPassword(user, user.PasswordHash, model.Password);
                    if (isCorrect == PasswordVerificationResult.Success)
                    {
                        user.PasswordHash = hasher.HashPassword(null, model.NewPassword);
                        IdentityResult result = await userManager.UpdateAsync(user);
                        await unitOfWork.CommitAsync();
                        return RedirectToAction("index","home");
                        //if (result.Succeeded) //Result - EmailInvalid error verir
                        //{
                        //    return RedirectToAction("index", "home");
                        //}
                    }
                    else
                        ModelState.AddModelError("Password", "Password is not correct.");
                }
            }

            return View(model);
        }
    }
}
