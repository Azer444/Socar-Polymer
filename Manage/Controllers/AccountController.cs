using Core;
using Core.Models;
using Manage.Areas.Admin.Models.ViewModels;
using Manage.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(IUnitOfWork unitOfWork,
            SignInManager<User> signInManager,
            UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl)
        {
            var model = new AccountLoginViewModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _unitOfWork.User.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(
                        user.UserName, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        if (string.IsNullOrEmpty(model.ReturnUrl))
                            return RedirectToAction("index", "home");

                        else if (Url.IsLocalUrl(model.ReturnUrl))
                            return LocalRedirect(model.ReturnUrl);
                    }
                }
            }

            ModelState.AddModelError(string.Empty, "Username or password is incorrect.");
            return View(model);
        }

        [HttpGet]
        public IActionResult Register(string returnUrl)
        {
            var model = new AccountRegisterViewModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FullName = model.FullName,
                    UserName = model.Email,
                    Email = model.Email,
                    Country = model.Country,
                    Company = model.Company,
                    Position = model.Position,
                    PhoneNumber = model.PhoneNumber
                };

                var result = await _unitOfWork.User.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Standart");

                    TempData["SuccessfullyRegistered"] = true;
                    return RedirectToAction("index", "home");
                }

                foreach (var error in result.Errors)
                {
                    if (error.Code != "DuplicateUserName")
                        ModelState.AddModelError(error.Code, error.Description);
                }
            }

            return View(model);
        }
    }
}
