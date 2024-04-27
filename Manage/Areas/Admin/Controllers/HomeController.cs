using Core;
using Core.Models;
using Manage.Areas.Admin.Models.ViewModels;
using Manage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Manage.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Manager, Admin")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IFileService fileService;

        public HomeController(IUnitOfWork unitOfWork,
            IFileService fileService)
        {
            this.unitOfWork = unitOfWork;
            this.fileService = fileService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = new HomeViewModel
            {
                HomeBannerComponent = await unitOfWork.HomeBannerComponent.GetAsync(),
                HomeSliderComponents = await unitOfWork.HomeSliderComponent.GetAllAsync()
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DefineBannerComponent()
        {
            var homeBannerComponent = await unitOfWork.HomeBannerComponent.GetAsync();
            if (homeBannerComponent == null)
                return View();

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DefineBannerComponent(HomeBannerComponent homeBannerComponent)
        {
            if (ModelState.IsValid)
            {
                homeBannerComponent.PhotoName = await fileService.UploadAsync(homeBannerComponent.Photo);

                await unitOfWork.HomeBannerComponent.CreateAsnyc(homeBannerComponent);
                await unitOfWork.CommitAsync();

                return RedirectToAction("index");
            }

            return View(homeBannerComponent);
        }

        [HttpGet]
        public async Task<IActionResult> EditBannerComponent()
        {
            var homeBannerComponent = await unitOfWork.HomeBannerComponent.GetAsync();
            if (homeBannerComponent != null)
            {
                var model = new HomeBannerComponentEditViewModel
                {
                    Id = homeBannerComponent.Id,
                    Title_AZ = homeBannerComponent.Title_AZ,
                    Title_RU = homeBannerComponent.Title_RU,
                    Title_EN = homeBannerComponent.Title_EN,
                    PhotoName = homeBannerComponent.PhotoName
                };

                return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditBannerComponent(HomeBannerComponentEditViewModel model)
        {
            var homeBannerComponent = await unitOfWork.HomeBannerComponent.GetAsync();                
            if (homeBannerComponent == null) return NotFound();

            if (!ModelState.IsValid) return View(model);

            homeBannerComponent.Title_AZ = model.Title_AZ;
            homeBannerComponent.Title_RU = model.Title_RU;
            homeBannerComponent.Title_EN = model.Title_EN;

            if (model.Photo != null)
            {
                fileService.Delete(homeBannerComponent.PhotoName);
                homeBannerComponent.PhotoName = await fileService.UploadAsync(model.Photo);
            }

            await unitOfWork.HomeBannerComponent.UpdateAsync(homeBannerComponent);
            await unitOfWork.CommitAsync();
            return RedirectToAction("index");
        }

        [HttpGet]
        public async Task<IActionResult> AddSliderComponent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSliderComponent(HomeSliderComponent homeSliderComponent)
        {
            if (!ModelState.IsValid) return View(homeSliderComponent);

            if (homeSliderComponent.Photo != null)
                homeSliderComponent.PhotoName = await fileService.UploadAsync(homeSliderComponent.Photo); 
            
            await unitOfWork.HomeSliderComponent.CreateAsnyc(homeSliderComponent);
            await unitOfWork.CommitAsync();

            return RedirectToAction("index");
        }

        [HttpGet]
        public async Task<IActionResult> EditSliderComponent(int id)
        {
            var homeSliderComponent = await unitOfWork.HomeSliderComponent.GetAsync(id);
            if (homeSliderComponent == null) return NotFound();

            var model = new HomeSliderComponentEditViewModel
            {
                Id = homeSliderComponent.Id,
                Title_AZ = homeSliderComponent.Title_AZ,
                Title_RU = homeSliderComponent.Title_RU,
                Title_EN = homeSliderComponent.Title_EN,
                Link = homeSliderComponent.Link,
                PhotoName = homeSliderComponent.PhotoName
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditSliderComponent(HomeSliderComponentEditViewModel model)
        {
            var homeSliderComponent = await unitOfWork.HomeSliderComponent.GetAsync(model.Id);
            if (homeSliderComponent == null) NotFound();

            if (!ModelState.IsValid) return View(model);

            if (model.Photo != null)
            {
                fileService.Delete(homeSliderComponent.PhotoName);
                homeSliderComponent.PhotoName = await fileService.UploadAsync(model.Photo);
            }

            homeSliderComponent.Title_AZ = model.Title_AZ;
            homeSliderComponent.Title_RU = model.Title_RU;
            homeSliderComponent.Title_EN = model.Title_EN;
            homeSliderComponent.Link = model.Link;

            await unitOfWork.HomeSliderComponent.UpdateAsync(homeSliderComponent);
            await unitOfWork.CommitAsync();

            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSliderComponent(int? id)
        {
            if (id != null)
            {
                var homeSliderComponent = await unitOfWork.HomeSliderComponent.GetAsync(id);
                if (homeSliderComponent != null)
                {
                    await unitOfWork.HomeSliderComponent.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }
    }
}
