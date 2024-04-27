using System.Threading.Tasks;
using Core;
using Core.Models;
using Manage.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Manage.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Manager, Admin")]
    public class LocationController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public LocationController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var locations = await unitOfWork.Location.GetAllAsync();
            return View(locations);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Location location)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.Location.CreateAsnyc(location);
                await unitOfWork.CommitAsync();

                return RedirectToAction("index");
            }

            return View(location);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var location = await unitOfWork.Location.GetAsync(id);
            return View(location);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Location location)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.Location.UpdateAsync(location);
                await unitOfWork.CommitAsync();

                return RedirectToAction("index");
            }

            return View(location);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                var location = await unitOfWork.Location.GetAsync(id);

                if (location != null)
                {
                    await unitOfWork.Location.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }
    }
}
