using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Models;
using Manage.Areas.Admin.Models.ViewModels;
using Manage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Manage.Controllers
{
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
            var model = new Models.ContactIndexViewModel
            {
                HeaderPartialViewModel = new HeaderPartialViewModel
                {
                    NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                },
                ContactTextComponent = await unitOfWork.ContactTextComponent.GetAsync(),
                ContactFormComponent = await unitOfWork.ContactFormComponent.GetAsync(),
                FooterPartialViewModel = new FooterPartialViewModel
                {
                    NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                }
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add_Message(ContactFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                var contactMessage = new ContactMessage
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    Email = model.Email,
                    Message = model.Message
                };

                await unitOfWork.ContactMessage.CreateAsnyc(contactMessage);
                await unitOfWork.CommitAsync();

                return Ok();
            }

            return NotFound();
        }
    }
}
