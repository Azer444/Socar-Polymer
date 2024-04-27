using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Manage.Models;
using Core;

namespace Manage.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.SuccessfullyRegistered = TempData["SuccessfullyRegistered"];

            var model = new HomeViewModel
            {
                HeaderPartialViewModel = new HeaderPartialViewModel
                {
                    NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                },
                FooterPartialViewModel = new FooterPartialViewModel
                {
                    NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                },
                HomeBannerComponent = await unitOfWork.HomeBannerComponent.GetAsync(),
                HomeSliderComponents = await unitOfWork.HomeSliderComponent.GetAllAsync(),
                NavTitleHomeComponents = await unitOfWork.NavTitleComponent.GetHomeComponentsAsync()
            };

            return View(model);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
