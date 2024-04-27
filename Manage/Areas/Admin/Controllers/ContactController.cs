using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Models;
using Manage.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Manage.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Manager, Admin")]
    public class ContactController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ContactController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = new ContactIndexViewModel
            {
                ContactTextComponent = await unitOfWork.ContactTextComponent.GetAsync(),
                ContactFormComponent = await unitOfWork.ContactFormComponent.GetAsync(),
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add_Text_Component()
        {
            var contactTextComponent = await unitOfWork.ContactTextComponent.GetAsync();
            if (contactTextComponent != null) return NotFound();

            return View(contactTextComponent);
        }

        [HttpPost]
        public async Task<IActionResult> Add_Text_Component(ContactTextComponent contactTextComponent)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.ContactTextComponent.CreateAsnyc(contactTextComponent);
                await unitOfWork.CommitAsync();

                return RedirectToAction("index");
            }

            return View(contactTextComponent);
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Text_Component()
        {
            var contactTextComponent = await unitOfWork.ContactTextComponent.GetAsync();
            if (contactTextComponent == null) return NotFound();

            return View(contactTextComponent);
        }

        [HttpPost]
        public async Task<IActionResult> Edit_Text_Component(ContactTextComponent contactTextComponent)
        {
            if (ModelState.IsValid)
            {
                var contactTextComponent_ = await unitOfWork.ContactTextComponent.GetAsync();
                if (contactTextComponent_ != null)
                {
                    contactTextComponent_.Content_AZ = contactTextComponent.Content_AZ;
                    contactTextComponent_.Content_RU = contactTextComponent.Content_RU;
                    contactTextComponent_.Content_EN = contactTextComponent.Content_EN;

                    await unitOfWork.ContactTextComponent.UpdateAsync(contactTextComponent_);
                    await unitOfWork.CommitAsync();

                    return RedirectToAction("index");
                }

                return NotFound();
            }

            return View(contactTextComponent);
        }

        [HttpGet]
        public async Task<IActionResult> Details_Text_Component()
        {
            var contactTextComponent = await unitOfWork.ContactTextComponent.GetAsync();
            if (contactTextComponent == null) return NotFound();

            return View(contactTextComponent);
        }

        [HttpGet]
        public async Task<IActionResult> Add_Form_Component()
        {
            var contactFormComponent = await unitOfWork.ContactFormComponent.GetAsync();
            if (contactFormComponent != null) return NotFound();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add_Form_Component(ContactFormComponent contactFormComponent)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.ContactFormComponent.CreateAsnyc(contactFormComponent);
                await unitOfWork.CommitAsync();

                return RedirectToAction("index");
            }

            return View(contactFormComponent);
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Form_Component()
        {
            var contactFormComponent = await unitOfWork.ContactFormComponent.GetAsync();
            if (contactFormComponent == null) return NotFound();

            return View(contactFormComponent);
        }

        [HttpPost]
        public async Task<IActionResult> Edit_Form_Component(ContactFormComponent contactFormComponent)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.ContactFormComponent.UpdateAsync(contactFormComponent);
                await unitOfWork.CommitAsync();

                return RedirectToAction("index");
            }

            return View(contactFormComponent);
        }

        [HttpGet]
        public async Task<IActionResult> Details_Form_Component()
        {
            var contactFormComponent = await unitOfWork.ContactFormComponent.GetAsync();
            if (contactFormComponent == null) return NotFound();

            return View(contactFormComponent);
        }

        [HttpGet]
        public async Task<IActionResult> Messages()
        {
            var contactMessages = await unitOfWork.ContactMessage.GetAllAsync();
            return View(contactMessages);
        }

        [HttpGet]
        public async Task<IActionResult> MessageDetails(int id)
        {
            var contactMessage = await unitOfWork.ContactMessage.GetAsync(id);
            if (contactMessage == null) return NotFound();

            return View(contactMessage);
        }
    }
}
