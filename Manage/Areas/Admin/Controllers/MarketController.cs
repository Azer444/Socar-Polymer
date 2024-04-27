using System.Threading.Tasks;
using Core;
using Core.Models;
using Manage.Areas.Admin.Models.ViewModels;
using Manage.Helpers;
using Manage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Manage.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Manager, Admin")]
    public class MarketController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IFileService fileService;

        public MarketController(IUnitOfWork unitOfWork,
            IFileService fileService)
        {
            this.unitOfWork = unitOfWork;
            this.fileService = fileService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var marketTitleComponents = await unitOfWork.MarketTitleComponent.GetAllAsync();
            return View(marketTitleComponents);
        }

        [HttpGet]
        public async Task<IActionResult> Add_Title_Component()
        {
            MarketTitleComponentAddViewModel model = new MarketTitleComponentAddViewModel
            {
                Locations = await unitOfWork.Location.GetSelectItemsAsync(),
                NavTitleComponents = await unitOfWork.NavTitleComponent.GetSelectItemsAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add_Title_Component(MarketTitleComponentAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                MarketTitleComponent marketTitleComponent = new MarketTitleComponent()
                {
                    LocationId = model.LocationId,
                    NavTitleComponentId = model.NavTitleComponentId,
                    Title_AZ = model.Title_AZ,
                    Title_RU = model.Title_RU,
                    Title_EN = model.Title_EN,
                    Slug = model.Slug,
                    Content_AZ = model.Content_AZ,
                    Content_RU = model.Content_RU,
                    Content_EN = model.Content_EN,
                    PhotoName = await fileService.UploadAsync(model.Photo)
                };

                await unitOfWork.MarketTitleComponent.CreateAsnyc(marketTitleComponent);
                await unitOfWork.CommitAsync();
                await unitOfWork.MarketTitleComponent.RegulateSlugAsync(marketTitleComponent);

                foreach (var file in model.Files)
                {
                    var file_ = new MarketTitleComponentFile()
                    {
                        MarketTitleComponentId = marketTitleComponent.Id,
                        FileName = await fileService.UploadAsync(file),
                        DisplayName = file.FileName,
                    };

                    await unitOfWork.MarketTitleComponentFile.CreateAsnyc(file_);
                    await unitOfWork.CommitAsync();
                }

                return RedirectToAction("index", "market");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Title_Component(int? id)
        {
            if (id != null)
            {
                var marketTitleComponent = await unitOfWork.MarketTitleComponent.GetAsync(id);
                if (marketTitleComponent != null)
                {
                    MarketTitleComponentEditViewModel model = new MarketTitleComponentEditViewModel()
                    {
                        Id = marketTitleComponent.Id,
                        Title_AZ = marketTitleComponent.Title_AZ,
                        Title_RU = marketTitleComponent.Title_RU,
                        Title_EN = marketTitleComponent.Title_EN,
                        Slug = marketTitleComponent.Slug,
                        Content_AZ = marketTitleComponent.Content_AZ,
                        Content_RU = marketTitleComponent.Content_RU,
                        Content_EN = marketTitleComponent.Content_EN,
                        LocationId = marketTitleComponent.LocationId,
                        Locations = await unitOfWork.Location.GetSelectItemsAsync(),
                        NavTitleComponentId = marketTitleComponent.NavTitleComponentId,
                        NavTitleComponents = await unitOfWork.NavTitleComponent.GetSelectItemsAsync(),
                        MarketTitleComponentFiles = marketTitleComponent.MarketTitleComponentFiles,
                        PhotoName = marketTitleComponent.PhotoName
                    };

                    return View(model);
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit_Title_Component(MarketTitleComponentEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var marketTitleComponent = await unitOfWork.MarketTitleComponent.GetAsync(model.Id);
                if (marketTitleComponent != null)
                {
                    marketTitleComponent.Title_AZ = model.Title_AZ;
                    marketTitleComponent.Title_RU = model.Title_RU;
                    marketTitleComponent.Title_EN = model.Title_EN;
                    marketTitleComponent.Content_AZ = model.Content_AZ;
                    marketTitleComponent.Content_RU = model.Content_RU;
                    marketTitleComponent.Content_EN = model.Content_EN;
                    marketTitleComponent.LocationId = model.LocationId;
                    marketTitleComponent.NavTitleComponentId = model.NavTitleComponentId;

                    if (model.Photo != null)
                    {
                        fileService.Delete(marketTitleComponent.PhotoName);
                        marketTitleComponent.PhotoName = await fileService.UploadAsync(model.Photo);
                    }

                    foreach (var file in model.Files)
                    {
                        var filename = await fileService.UploadAsync(file);
                        var file_ = new MarketTitleComponentFile()
                        {
                            FileName = filename,
                            DisplayName = file.FileName,
                            MarketTitleComponentId = marketTitleComponent.Id,
                        };

                        await unitOfWork.MarketTitleComponentFile.CreateAsnyc(file_);
                        await unitOfWork.CommitAsync();
                        await unitOfWork.MarketTitleComponent.RegulateSlugAsync(marketTitleComponent);
                    }

                    await unitOfWork.MarketTitleComponent.UpdateAsync(marketTitleComponent);
                    await unitOfWork.CommitAsync();

                    return RedirectToAction("detail_title_component", "market", new { id = marketTitleComponent.Id });
                };

                return NotFound();
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Detail_Title_Component(int? id)
        {
            if (id != null)
            {
                var marketTitleComponent = await unitOfWork.MarketTitleComponent.GetAsync(id);
                if (marketTitleComponent != null)
                    return View(marketTitleComponent);
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete_Title_Component(int? id)
        {
            if (id != null)
            {
                var marketTitleComponent = await unitOfWork.MarketTitleComponent.GetAsync(id);
                if (marketTitleComponent != null)
                {
                    foreach (var marketComponent in marketTitleComponent.MarketComponents)
                    {
                        fileService.Delete(marketComponent.PhotoName);
                        foreach (var marketComponentFile in marketComponent.MarketComponentFiles)
                            fileService.Delete(marketComponentFile.FileName);

                        foreach (var marketSubComponent in marketComponent.MarketSubComponents)
                        {
                            fileService.Delete(marketComponent.PhotoName);
                            foreach (var marketSubComponentFile in marketSubComponent.MarketSubComponentFiles)
                                fileService.Delete(marketSubComponentFile.FileName);
                        }
                    }

                    await unitOfWork.MarketTitleComponent.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete_Title_Component_File(int? id)
        {
            if (id != null)
            {
                var titleComponentFile = await unitOfWork.MarketTitleComponentFile.GetAsync(id);
                if (titleComponentFile != null)
                {
                    await unitOfWork.MarketTitleComponentFile.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Add_Component(int? id)
        {
            var titleComponent = await unitOfWork.MarketTitleComponent.GetAsync(id);
            if (titleComponent != null)
            {
                ViewBag.TitleComponentTitle = titleComponent.Title_EN;
                return View();
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Add_Component(MarketComponentAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                var marketTitleComponent = await unitOfWork.MarketTitleComponent.GetAsync(model.MarketTitleComponentId);
                if (marketTitleComponent != null)
                {
                    MarketComponent marketComponent = new MarketComponent()
                    {
                        MarketTitleComponentId = marketTitleComponent.Id,
                        Title_AZ = model.Title_AZ,
                        Title_RU = model.Title_RU,
                        Title_EN = model.Title_EN,
                        Slug = model.Slug,
                        Content_AZ = model.Content_AZ,
                        Content_RU = model.Content_RU,
                        Content_EN = model.Content_EN,
                        PhotoName = await fileService.UploadAsync(model.Photo)
                    };

                    await unitOfWork.MarketComponent.CreateAsnyc(marketComponent);
                    await unitOfWork.CommitAsync();
                    await unitOfWork.MarketComponent.RegulateSlugAsync(marketComponent);

                    foreach (var file in model.Files)
                    {
                        var file_ = new MarketComponentFile()
                        {
                            MarketComponentId = marketComponent.Id,
                            FileName = await fileService.UploadAsync(file),
                            DisplayName = file.FileName
                        };

                        await unitOfWork.MarketComponentFile.CreateAsnyc(file_);
                        await unitOfWork.CommitAsync();
                    }

                    return RedirectToAction("detail_title_component", "market", new { id = marketComponent.MarketTitleComponentId });
                }

                return NotFound();
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Component(int? id)
        {
            if (id != null)
            {
                var marketComponent = await unitOfWork.MarketComponent.GetAsync(id);
                if (marketComponent != null)
                {
                    MarketComponentEditViewModel model = new MarketComponentEditViewModel()
                    {
                        Id = marketComponent.Id,
                        Title_AZ = marketComponent.Title_AZ,
                        Title_RU = marketComponent.Title_RU,
                        Title_EN = marketComponent.Title_EN,
                        Slug = marketComponent.Slug,
                        Content_AZ = marketComponent.Content_AZ,
                        Content_RU = marketComponent.Content_RU,
                        Content_EN = marketComponent.Content_EN,
                        PhotoName = marketComponent.PhotoName,
                        MarketTitleComponentId = marketComponent.MarketTitleComponentId,
                        MarketComponentFiles = marketComponent.MarketComponentFiles
                    };

                    ViewBag.TitleComponentTitle = marketComponent.MarketTitleComponent.Title_EN;
                    return View(model);
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit_Component(MarketComponentEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var marketComponent = await unitOfWork.MarketComponent.GetAsync(model.Id);
                if (marketComponent != null)
                {
                    marketComponent.Title_AZ = model.Title_AZ;
                    marketComponent.Title_RU = model.Title_RU;
                    marketComponent.Title_EN = model.Title_EN;
                    marketComponent.Slug = model.Slug;
                    marketComponent.Content_AZ = model.Content_AZ;
                    marketComponent.Content_RU = model.Content_RU;
                    marketComponent.Content_EN = model.Content_EN;

                    if (model.Photo != null)
                    {
                        fileService.Delete(marketComponent.PhotoName);
                        marketComponent.PhotoName = await fileService.UploadAsync(model.Photo);
                    }

                    foreach (var file in model.Files)
                    {
                        var filename = await fileService.UploadAsync(file);

                        var file_ = new MarketComponentFile()
                        {
                            FileName = filename,
                            DisplayName = file.FileName,
                            MarketComponentId = marketComponent.Id
                        };

                        await unitOfWork.MarketComponentFile.CreateAsnyc(file_);
                        await unitOfWork.CommitAsync();
                    }

                    await unitOfWork.MarketComponent.UpdateAsync(marketComponent);
                    await unitOfWork.CommitAsync();
                    await unitOfWork.MarketComponent.RegulateSlugAsync(marketComponent);

                    return RedirectToAction("detail_component", "market", new { id = marketComponent.Id });
                };

                return NotFound();
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Detail_Component(int? id)
        {
            if (id != null)
            {
                var marketComponent = await unitOfWork.MarketComponent.GetAsync(id);
                if (marketComponent != null)
                    return View(marketComponent);
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete_Component(int? id)
        {
            if (id != null)
            {
                var marketComponent = await unitOfWork.MarketComponent.GetAsync(id);
                if (marketComponent != null)
                {
                    fileService.Delete(marketComponent.PhotoName);
                    foreach (var marketSubComponent in marketComponent.MarketSubComponents)
                    {
                        fileService.Delete(marketComponent.PhotoName);
                        foreach (var marketSubComponentFile in marketSubComponent.MarketSubComponentFiles)
                            fileService.Delete(marketSubComponentFile.FileName);
                    }

                    await unitOfWork.MarketComponent.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete_Component_File(int? id)
        {
            if (id != null)
            {
                var componentFile = await unitOfWork.MarketComponentFile.GetAsync(id);
                if (componentFile != null)
                {
                    await unitOfWork.MarketComponentFile.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Add_SubComponent(int? id)
        {
            var component = await unitOfWork.MarketComponent.GetAsync(id);
            if (component != null)
            {
                ViewBag.ComponentTitle = component.Title_EN;
                return View();
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Add_SubComponent(MarketSubComponentAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                var marketComponent = await unitOfWork.MarketComponent.GetAsync(model.MarketComponentId);
                if (marketComponent != null)
                {
                    MarketSubComponent marketSubComponent = new MarketSubComponent()
                    {
                        MarketComponentId = model.MarketComponentId,
                        Title_AZ = model.Title_AZ,
                        Title_RU = model.Title_RU,
                        Title_EN = model.Title_EN,
                        Slug = model.Slug,
                        Content_AZ = model.Content_AZ,
                        Content_RU = model.Content_RU,
                        Content_EN = model.Content_EN,
                        PhotoName = model.Photo != null ? await fileService.UploadAsync(model.Photo) : null
                    };

                    await unitOfWork.MarketSubComponent.CreateAsnyc(marketSubComponent);
                    await unitOfWork.CommitAsync();
                    await unitOfWork.MarketSubComponent.RegulateSlugAsync(marketSubComponent);


                    foreach (var file in model.Files)
                    {
                        var file_ = new MarketSubComponentFile()
                        {
                            MarketSubComponentId = marketSubComponent.Id,
                            FileName = await fileService.UploadAsync(file),
                            DisplayName = file.FileName
                        };

                        await unitOfWork.MarketSubComponentFile.CreateAsnyc(file_);
                        await unitOfWork.CommitAsync();
                    }

                    return RedirectToAction("detail_component", "market", new { id = marketSubComponent.MarketComponentId });
                }

                return NotFound();
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit_SubComponent(int? id)
        {
            if (id != null)
            {
                var marketSubComponent = await unitOfWork.MarketSubComponent.GetAsync(id);
                if (marketSubComponent != null)
                {
                    MarketSubComponentEditViewModel model = new MarketSubComponentEditViewModel()
                    {
                        Id = marketSubComponent.Id,
                        Title_AZ = marketSubComponent.Title_AZ,
                        Title_RU = marketSubComponent.Title_RU,
                        Title_EN = marketSubComponent.Title_EN,
                        Slug = marketSubComponent.Slug,
                        Content_AZ = marketSubComponent.Content_AZ,
                        Content_RU = marketSubComponent.Content_RU,
                        Content_EN = marketSubComponent.Content_EN,
                        MarketComponentId = marketSubComponent.MarketComponentId,
                        PhotoName = marketSubComponent.PhotoName,
                        MarketSubComponentFiles = marketSubComponent.MarketSubComponentFiles
                    };

                    ViewBag.ComponentTitle = marketSubComponent.MarketComponent.Title_EN;
                    return View(model);
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit_SubComponent(MarketSubComponentEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var marketSubComponent = await unitOfWork.MarketSubComponent.GetAsync(model.Id);
                if (marketSubComponent != null)
                {
                    marketSubComponent.Title_AZ = model.Title_AZ;
                    marketSubComponent.Title_RU = model.Title_RU;
                    marketSubComponent.Title_EN = model.Title_EN;
                    marketSubComponent.Slug = model.Slug;
                    marketSubComponent.Content_AZ = model.Content_AZ;
                    marketSubComponent.Content_RU = model.Content_RU;
                    marketSubComponent.Content_EN = model.Content_EN;

                    if (model.Photo != null)
                    {
                        if (!string.IsNullOrEmpty(marketSubComponent.PhotoName))
                            fileService.Delete(marketSubComponent.PhotoName);
                        await fileService.UploadAsync(model.Photo);
                    }

                    foreach (var file in model.Files)
                    {
                        var file_ = new MarketSubComponentFile()
                        {
                            FileName = await fileService.UploadAsync(file),
                            DisplayName = file.FileName,
                            MarketSubComponentId = marketSubComponent.Id
                        };

                        await unitOfWork.MarketSubComponentFile.CreateAsnyc(file_);
                        await unitOfWork.CommitAsync();
                    }

                    await unitOfWork.MarketSubComponent.UpdateAsync(marketSubComponent);
                    await unitOfWork.CommitAsync();
                    await unitOfWork.MarketSubComponent.RegulateSlugAsync(marketSubComponent);

                    return RedirectToAction("detail_subcomponent", "market", new { id = marketSubComponent.Id });
                };

                return NotFound();
            }

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Detail_SubComponent(int? id)
        {
            if (id != null)
            {
                var marketSubComponent = await unitOfWork.MarketSubComponent.GetAsync(id);
                if (marketSubComponent != null)
                    return View(marketSubComponent);
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete_SubComponent(int? id)
        {
            if (id != null)
            {
                var marketSubComponent = await unitOfWork.MarketSubComponent.GetAsync(id);
                if (marketSubComponent != null)
                {
                    fileService.Delete(marketSubComponent.PhotoName);
                    foreach (var marketSubComponentFile in marketSubComponent.MarketSubComponentFiles)
                        fileService.Delete(marketSubComponentFile.FileName);

                    await unitOfWork.MarketSubComponent.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete_SubComponent_File(int? id)
        {
            if (id != null)
            {
                var subComponentFile = await unitOfWork.MarketSubComponentFile.GetAsync(id);
                if (subComponentFile != null)
                {
                    await unitOfWork.MarketSubComponentFile.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Upload_Image(IFormFile upload)
        {
            if (upload != null)
            {
                var fileName = await fileService.UploadAsync(upload);
                var url = $"{"/uploads/"}{fileName}";
                var success = new UploadSuccess
                {
                    Uploaded = 1,
                    FileName = fileName,
                    Url = url
                };

                return new JsonResult(success);
            }

            return null;
        }
    }
}

