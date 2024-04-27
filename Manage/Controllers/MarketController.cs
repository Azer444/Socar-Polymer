using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Manage.Models;
using Manage.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manage.Controllers
{
    [Route("{lang:languages}/[controller]/{location:locations}")]
    public class MarketController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public MarketController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string location)
        {
            var model = new MarketIndexViewModel
            {
                HeaderPartialViewModel = new HeaderPartialViewModel
                {
                    NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                },
                FooterPartialViewModel = new FooterPartialViewModel
                {
                    NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                },
                MarketTitleComponents = await unitOfWork.MarketTitleComponent.GetAllByLocationAsync(location)
            };

            return View(model);
        }

        [HttpGet("{slug_title}")]
        public async Task<IActionResult> Title_Component(string slug_title)
        {
            if (!string.IsNullOrEmpty(slug_title))
            {
                var marketTitleComponent = await unitOfWork.MarketTitleComponent.GetBySlugAsync(slug_title);
                if (marketTitleComponent != null)
                {
                    var model = new TitleComponentViewModel
                    {
                        HeaderPartialViewModel = new HeaderPartialViewModel
                        {
                            NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                        },
                        FooterPartialViewModel = new FooterPartialViewModel
                        {
                            NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                        },
                        MarketTitleComponent = marketTitleComponent
                    };
                    return View(model);
                }
            }

            return NotFound();
        }

        [HttpGet("{slug_title}/{slug}")]
        public async Task<IActionResult> Component(string slug_title, string slug)
        {
            if (!string.IsNullOrEmpty(slug))
            {
                var marketComponent = await unitOfWork.MarketComponent.GetBySlugAsync(slug);
                if (marketComponent != null)
                {
                    if (marketComponent.MarketTitleComponent.Slug.ToLower() == slug_title.ToLower())
                    {
                        var model = new ComponentViewModel
                        {
                            HeaderPartialViewModel = new HeaderPartialViewModel
                            {
                                NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                            },
                            FooterPartialViewModel = new FooterPartialViewModel
                            {
                                NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                            },
                            MarketComponent = marketComponent
                        };
                        return View(model);
                    }
                }
            }

            return NotFound();
        }

        [HttpGet("{slug_title}/{slug}/{slug_sub}")]
        public async Task<IActionResult> SubComponent(string slug_title, string slug, string slug_sub)
        {
            if (!string.IsNullOrEmpty(slug_sub))
            {
                var marketSubComponent = await unitOfWork.MarketSubComponent.GetBySlugAsync(slug_sub);
                if (marketSubComponent != null)
                {
                    if (marketSubComponent.MarketComponent.Slug == slug.ToLower() &&
                        marketSubComponent.MarketComponent.MarketTitleComponent.Slug.ToLower() == slug_title.ToLower())
                    {
                        var model = new SubComponentViewModel
                        {
                            HeaderPartialViewModel = new HeaderPartialViewModel
                            {
                                NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                            },
                            FooterPartialViewModel = new FooterPartialViewModel
                            {
                                NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                            },
                            MarketSubComponent = marketSubComponent
                        };
                        return View(model);
                    }
                }
            }

            return NotFound();
        }
    }
}
