using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Models;
using Manage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Manage.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = new ProductViewModel
            {
                HeaderPartialViewModel = new HeaderPartialViewModel
                {
                    NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                },
                ProductTitleCategories = await unitOfWork.ProductTitleCategory.GetAllAsync(),
                ProductSearchViewModel = new ProductSearchViewModel
                {
                    ProductTitleCategoriesForFilter = (await unitOfWork.ProductTitleCategory.GetAllAsync()).Select(c => new ProductTitleCategoryFilter
                    {
                        Id = c.Id,
                        Name_AZ = c.Name_AZ,
                        Name_RU = c.Name_RU,
                        Name_EN = c.Name_EN,
                        Categories = c.ProductCategories.Select(sc => new ProductCategoryFilter
                        {
                            Id = sc.Id,
                            Name_AZ = sc.Name_AZ,
                            Name_RU = sc.Name_RU,
                            Name_EN = sc.Name_EN
                        })
                       .ToArray()
                    })
                .ToArray(),
                },
                FooterPartialViewModel = new FooterPartialViewModel
                {
                    NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                }
            };

            foreach (var productTitleCategory in model.ProductTitleCategories)
            {
                foreach (var productCategory in productTitleCategory.ProductCategories)
                {
                    model.Count += productCategory.Products.Count;
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.Success = TempData["Success"];
            ViewBag.Error = TempData["Error"];

            if (id != null)
            {
                var product = await unitOfWork.Product.GetAsync(id);
                if (product != null)
                {
                    var model = new ProductDetailsViewModel
                    {
                        HeaderPartialViewModel = new HeaderPartialViewModel
                        {
                            NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                        },
                        Product = product,
                        FooterPartialViewModel = new FooterPartialViewModel
                        {
                            NavTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync()
                        }
                    };

                    return View(model);
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ProductDetailsViewModel model)
        {
            if (TryValidateModel(model.ProductContactFormModel))
            {
                var productContactMessage = new ProductContactMessage
                {
                    FirstName = model.ProductContactFormModel.FirstName,
                    LastName = model.ProductContactFormModel.LastName,
                    Company = model.ProductContactFormModel.Company,
                    Content = model.ProductContactFormModel.Content,
                    Country = model.ProductContactFormModel.Country,
                    Email = model.ProductContactFormModel.Email,
                    NatureRequest = model.ProductContactFormModel.NatureRequest,
                    Phone = model.ProductContactFormModel.Phone,
                    Position = model.ProductContactFormModel.Position
                };

                await unitOfWork.ProductContactMessage.CreateAsnyc(productContactMessage);
                await unitOfWork.CommitAsync();

                TempData["Success"] = true;
                return RedirectToAction("details", "product", new { id = model.ProductContactFormModel.ProductId });
            }

            TempData["Error"] = true;
            return RedirectToAction("details", "product", new { id = model.ProductContactFormModel.ProductId });
        }

        [HttpPost]
        public async Task<IActionResult> Filter(ProductViewModel model, string lang)
        {
            if (TryValidateModel(model.ProductSearchViewModel))
            {
                var result = new ProductFilterResultViewModel();

                if (model.ProductSearchViewModel.All)
                    result.ProductTitleCategories = (await unitOfWork.ProductTitleCategory.GetAllAsync()).Select(ptc => new ProductTitleCategoryMap
                    {
                        Id = ptc.Id,
                        Name = unitOfWork.Translation.GetAsync(ptc, "Name", lang),
                        ProductCategories = ptc.ProductCategories.Select(pc => new ProductCategoryMap
                        {
                            Id = pc.Id,
                            Name = unitOfWork.Translation.GetAsync(pc, "Name", lang),
                            ProductTitleCategoryId = pc.ProductTitleCategoryId,
                            Products = pc.Products.Select(p => new ProductMap
                            {
                                ProductFields = p.ProductFields.Select(pf => new ProductFieldMap
                                {
                                    Content = unitOfWork.Translation.GetAsync(pf, "Content", lang)
                                })
                                .ToList()
                            })
                            .ToList(),
                            ProductCategoryProperties = pc.ProductCategoryProperties.Select(pcp => new ProductCategoryPropertyMap
                            {
                                Name = unitOfWork.Translation.GetAsync(pcp, "Name", lang)
                            })
                            .ToList(),
                        }).ToList(),
                    }).ToList();
                else
                {
                    foreach (var productTitleCategoryFilter in model.ProductSearchViewModel.ProductTitleCategoriesForFilter)
                    {
                        if (productTitleCategoryFilter.Selected)
                        {
                            var productTitleCategory = await unitOfWork.ProductTitleCategory.GetAsync(productTitleCategoryFilter.Id);
                            if (productTitleCategory != null)
                            {
                                var productTitleCategoryMap = new ProductTitleCategoryMap
                                {
                                    Id = productTitleCategory.Id,
                                    Name = unitOfWork.Translation.GetAsync(productTitleCategory, "Name", lang),
                                    ProductCategories = productTitleCategory.ProductCategories.Select(pc => new ProductCategoryMap
                                    {
                                        Name = unitOfWork.Translation.GetAsync(pc, "Name", lang),
                                        ProductCategoryProperties = pc.ProductCategoryProperties.Select(pcp => new ProductCategoryPropertyMap
                                        {
                                            Name = unitOfWork.Translation.GetAsync(pcp, "Name", lang)
                                        })
                                        .ToList(),
                                        Products = pc.Products.Select(p => new ProductMap
                                        {
                                            ProductFields = p.ProductFields.Select(pf => new ProductFieldMap
                                            {
                                                Content = unitOfWork.Translation.GetAsync(pf, "Content", lang)
                                            })
                                           .ToList()
                                        })
                                        .ToList(),
                                        ProductTitleCategoryId = pc.ProductTitleCategoryId
                                    }).ToList(),
                                };

                                result.ProductTitleCategories.Add(productTitleCategoryMap);
                            }
                        }
                        else
                        {
                            foreach (var categoryFilter in productTitleCategoryFilter.Categories)
                            {
                                if (categoryFilter.Selected)
                                {
                                    var productCategory = await unitOfWork.ProductCategory.GetAsync(categoryFilter.Id);
                                    if (productCategory != null)
                                    {
                                        var productCategoryMap = new ProductCategoryMap
                                        {
                                            Id = productCategory.Id,
                                            ProductTitleCategoryId = productCategory.ProductTitleCategory.Id,
                                            Name = unitOfWork.Translation.GetAsync(productCategory, "Name", lang),
                                            ProductCategoryProperties = productCategory.ProductCategoryProperties.Select(pcp => new ProductCategoryPropertyMap
                                            {
                                                Name = unitOfWork.Translation.GetAsync(pcp, "Name", lang)
                                            })
                                            .ToList(),
                                            Products = productCategory.Products.Select(p => new ProductMap
                                            {
                                                ProductFields = p.ProductFields.Select(pf => new ProductFieldMap
                                                {
                                                    Content = unitOfWork.Translation.GetAsync(pf, "Content", lang)
                                                })
                                           .ToList()
                                            })
                                        .ToList(),
                                        };

                                        var productTitleCategoryMap = result.ProductTitleCategories.FirstOrDefault(ptc => ptc.Id == productCategory.ProductTitleCategoryId);
                                        if (productTitleCategoryMap == null)
                                        {
                                            productTitleCategoryMap = new ProductTitleCategoryMap
                                            {
                                                Id = productCategory.ProductTitleCategory.Id,
                                                Name = unitOfWork.Translation.GetAsync(productCategory.ProductTitleCategory, "Name", lang),
                                            };

                                            result.ProductTitleCategories.Add(productTitleCategoryMap);
                                        }

                                        productTitleCategoryMap.ProductCategories.Add(productCategoryMap);
                                    }
                                }
                            }
                        }
                    }
                }

                foreach (var productTitleCategory in result.ProductTitleCategories)
                {
                    foreach (var productCategory in productTitleCategory.ProductCategories)
                    {
                        result.Count += productCategory.Products.Count;
                    }
                }

                return Ok(result);
            }

            return View(model);
        }
    }
}
