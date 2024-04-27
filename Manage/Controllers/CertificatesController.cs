using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Manage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Manage.Controllers
{
    public class CertificatesController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public CertificatesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = new CertificatesIndexViewModel
            {
                HeaderPartialViewModel = new HeaderPartialViewModel
                {
                    NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                },
                CertificateComponents = await unitOfWork.CertificateComponent.GetAllAsync(),
                FooterPartialViewModel = new FooterPartialViewModel
                {
                    NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                }
            };

            return View(model);
        }

        [Route("{lang:languages}/[controller]/{slug}")]
        public async Task<IActionResult> Component(string slug)
        {
            if (!string.IsNullOrEmpty(slug))
            {
                var model = new CertificatesDetailsViewModel
                {
                    HeaderPartialViewModel = new HeaderPartialViewModel
                    {
                        NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                    },
                    CertificateComponent = await unitOfWork.CertificateComponent.GetBySlugAsync(slug),
                    FooterPartialViewModel = new FooterPartialViewModel
                    {
                        NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                    }
                };

                return View(model);
            }

            return NotFound();
        }
    }
}
