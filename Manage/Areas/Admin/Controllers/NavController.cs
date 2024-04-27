using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Models;
using Manage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Manage.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Manager, Admin")]
    public class NavController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IFileService fileService;

        public NavController(IUnitOfWork unitOfWork,
            IFileService fileService)
        {
            this.unitOfWork = unitOfWork;
            this.fileService = fileService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var navTitleComponents = await unitOfWork.NavTitleComponent.GetAllAsync();
            return View(navTitleComponents);
        }

        [HttpGet]
        public async Task<IActionResult> Add_Title_Component()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add_Title_Component(NavTitleComponent navTitleComponent)
        {
            if (ModelState.IsValid)
            {
                if (navTitleComponent.Photo != null)
                    navTitleComponent.PhotoName = await fileService.UploadAsync(navTitleComponent.Photo);

                await unitOfWork.NavTitleComponent.CreateAsnyc(navTitleComponent);
                await unitOfWork.CommitAsync();

                return RedirectToAction("index");
            }

            return View(navTitleComponent);
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Title_Component(int? id)
        {
            if (id != null)
            {
                var navTitleComponent = await unitOfWork.NavTitleComponent.GetAsync(id);
                if (navTitleComponent != null)
                    return View(navTitleComponent);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit_Title_Component(NavTitleComponent navTitleComponent)
        {
            if (ModelState.IsValid)
            {
                if (navTitleComponent.Photo != null)
                {
                    if (!string.IsNullOrEmpty(navTitleComponent.PhotoName))
                        fileService.Delete(navTitleComponent.PhotoName);

                    navTitleComponent.PhotoName = await fileService.UploadAsync(navTitleComponent.Photo);
                }

                await unitOfWork.NavTitleComponent.UpdateAsync(navTitleComponent);
                await unitOfWork.CommitAsync();

                return RedirectToAction("detail_title_component", "nav", new { id = navTitleComponent.Id });
            }

            return View(navTitleComponent);
        }

        [HttpGet]
        public async Task<IActionResult> Detail_Title_Component(int? id)
        {
            if (id != null)
            {
                var navbarTitleComponent = await unitOfWork.NavTitleComponent.GetAsync(id);
                if (navbarTitleComponent != null)
                    return View(navbarTitleComponent);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete_Title_Component(int? id)
        {
            if (id != null)
            {
                var navbarTitleComponent = await unitOfWork.NavTitleComponent.GetAsync(id);
                if (navbarTitleComponent != null)
                {
                    await unitOfWork.NavTitleComponent.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Add_Component(int? id)
        {
            if (id != null)
            {
                var navTitleComponent = await unitOfWork.NavTitleComponent.GetAsync(id);
                if (navTitleComponent != null)
                {
                    ViewBag.TitleComponentTitle = navTitleComponent.Title_EN;
                    return View();
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Add_Component(NavComponent navComponent)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.NavComponent.CreateAsnyc(navComponent);
                await unitOfWork.CommitAsync();

                return RedirectToAction("detail_title_component", "nav", new { id = navComponent.NavTitleComponentId });
            }

            return View(navComponent);
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Component(int? id)
        {
            if (id != null)
            {
                var navComponent = await unitOfWork.NavComponent.GetAsync(id);
                if (navComponent != null)
                {
                    ViewBag.TitleComponentTitle = navComponent.NavTitleComponent.Title_EN;
                    return View(navComponent);
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit_Component(NavComponent navComponent)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.NavComponent.UpdateAsync(navComponent);
                await unitOfWork.CommitAsync();

                return RedirectToAction("detail_title_component", "nav", new { id = navComponent.NavTitleComponentId });
            }

            return View(navComponent);
        }

        [HttpGet]
        public async Task<IActionResult> Detail_Component(int? id)
        {
            if (id != null)
            {
                var navbarComponent = await unitOfWork.NavComponent.GetAsync(id);
                if (navbarComponent != null)
                    return View(navbarComponent);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete_Component(int? id)
        {
            if (id != null)
            {
                var navComponent = await unitOfWork.NavComponent.GetAsync(id);
                if (navComponent != null)
                {
                    await unitOfWork.NavComponent.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }
    }
}
