using Core;
using Manage.Areas.Admin.Models.ViewModels;
using Manage.Models;
using Manage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Manager, Admin")]
    public class UserController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IEmailService emailService;

        public UserController(IUnitOfWork unitOfWork,
            IEmailService emailService)
        {
            this.unitOfWork = unitOfWork;
            this.emailService = emailService;
        }

        [HttpGet]
        public async Task<IActionResult> CheckList()
        {
            var model = new UserCheckViewModel
            {
                Users = await unitOfWork.User.GetAllWaitingConfirmedAsync()
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Check(string id)
        {
            var user = await unitOfWork.User.FindByIdAsync(id);
            if (user == null) return NotFound();

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Confirm(string id)
        {
            var user = await unitOfWork.User.FindByIdAsync(id);
            if (user == null) return NotFound();

            user.EmailConfirmed = true;
            await unitOfWork.User.UpdateAsync(user);
            await unitOfWork.CommitAsync();

            await emailService.SendEmailAsync("Socar Polymer Registration", "Your registration apply accepted by moderation. You can sign in site by clicking <a href='https://socar.labrin.tech/en/account/login'>here</a>", user.Email);

            return RedirectToAction("checklist");
        }
    }
}
