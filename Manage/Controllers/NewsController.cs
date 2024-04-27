using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Manage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Manage.Controllers
{
    public class NewsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public NewsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = new NewsViewModel
            {
                HeaderPartialViewModel = new HeaderPartialViewModel
                {
                    NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                },
                FooterPartialViewModel = new FooterPartialViewModel
                {
                    NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                },
                News = await unitOfWork.News.GetAllAsync()
            };

            return View(model);
        }

        [Route("{lang:languages}/[controller]/{slug}")]
        public async Task<IActionResult> Index(string slug)
        {
            if (!string.IsNullOrEmpty(slug))
            {
                var model = new NewsViewModel
                {
                    HeaderPartialViewModel = new HeaderPartialViewModel
                    {
                        NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                    },
                    FooterPartialViewModel = new FooterPartialViewModel
                    {
                        NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                    },
                    News_ = await unitOfWork.News.GetBySlugAsync(slug)
                };

                return View(model);
            }

            return NotFound();
        }

    }
}
