using System;
using System.Collections.Generic;
using System.Linq;
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
    public class CertificateController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IFileService fileService;

        public CertificateController(IUnitOfWork unitOfWork,
            IFileService fileService)
        {
            this.unitOfWork = unitOfWork;
            this.fileService = fileService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var certificateComponents = await unitOfWork.CertificateComponent.GetAllAsync();
            return View(certificateComponents);
        }

        [HttpGet]
        public async Task<IActionResult> Add_Component()
        {
            var model = new CertificateComponentAddViewModel
            {
                NavTitleComponents = await unitOfWork.NavTitleComponent.GetSelectItemsAsync()
            };
            return View(model);
        }

        [HttpPost,DisableRequestSizeLimit]
        public async Task<IActionResult> Add_Component(CertificateComponentAddViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var certificateComponent = new CertificateComponent
            {
                Title_AZ = model.Title_AZ,
                Title_RU = model.Title_RU,
                Title_EN = model.Title_EN,
                Slug = model.Slug,
                Content_AZ = model.Content_AZ,
                Content_RU = model.Content_RU,
                Content_EN = model.Content_EN,
                PhotoName = model.Photo != null ? await fileService.UploadAsync(model.Photo) : null,
                NavTitleComponentId = model.NavTitleComponentId
            };
            if (model.File_AZ != null)
                certificateComponent.FileName_AZ = await fileService.UploadAsync(model.File_AZ);
            if (model.File_EN != null)
                certificateComponent.FileName_EN = await fileService.UploadAsync(model.File_EN);
            if (model.File_RU != null)
                certificateComponent.FileName_RU = await fileService.UploadAsync(model.File_RU);
            await unitOfWork.CertificateComponent.CreateAsnyc(certificateComponent);
            await unitOfWork.CommitAsync();
            await unitOfWork.CertificateComponent.RegulateSlugAsync(certificateComponent);
            await unitOfWork.CommitAsync();
            return RedirectToAction("index", "certificate");
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Component(int id)
        {
            var certificateComponent = await unitOfWork.CertificateComponent.GetAsync(id);
            if (certificateComponent == null) return NotFound();
            var model = new CertificateComponentEditViewModel
            {
                Id = certificateComponent.Id,
                Title_AZ = certificateComponent.Title_AZ,
                Title_RU = certificateComponent.Title_RU,
                Title_EN = certificateComponent.Title_EN,
                Slug = certificateComponent.Slug,
                Content_AZ = certificateComponent.Content_AZ,
                Content_RU = certificateComponent.Content_RU,
                Content_EN = certificateComponent.Content_EN,
                PhotoName = certificateComponent.PhotoName,
                NavTitleComponentId = certificateComponent.NavTitleComponentId,
                NavTitleComponents = await unitOfWork.NavTitleComponent.GetSelectItemsAsync()
            };
            return View(model);
        }

        [HttpPost,DisableRequestSizeLimit]
        public async Task<IActionResult> Edit_Component(CertificateComponentEditViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var certificateComponent = await unitOfWork.CertificateComponent.GetAsync(model.Id);
            if (certificateComponent == null) return NotFound();
            certificateComponent.Title_AZ = model.Title_AZ;
            certificateComponent.Title_RU = model.Title_RU;
            certificateComponent.Title_EN = model.Title_EN;
            certificateComponent.Slug = model.Slug;
            certificateComponent.Content_AZ = model.Content_AZ;
            certificateComponent.Content_RU = model.Content_RU;
            certificateComponent.Content_EN = model.Content_EN;
            certificateComponent.NavTitleComponentId = model.NavTitleComponentId;
            if (model.Photo != null)
            {
                fileService.Delete(certificateComponent.PhotoName);
                certificateComponent.PhotoName = await fileService.UploadAsync(model.Photo);
            }
            if (model.File_AZ != null)
            {
                fileService.Delete(certificateComponent.FileName_AZ);
                certificateComponent.FileName_AZ = await fileService.UploadAsync(model.File_AZ);
            }
            if (model.File_EN != null)
            {
                fileService.Delete(certificateComponent.FileName_EN);
                certificateComponent.FileName_EN = await fileService.UploadAsync(model.File_EN);
            }
            if (model.File_RU != null)
            {
                fileService.Delete(certificateComponent.FileName_RU);
                certificateComponent.FileName_RU = await fileService.UploadAsync(model.File_RU);
            }
            await unitOfWork.CertificateComponent.UpdateAsync(certificateComponent);
            await unitOfWork.CertificateComponent.RegulateSlugAsync(certificateComponent);
            await unitOfWork.CommitAsync();
            return RedirectToAction("detail_component", "certificate", new { id = certificateComponent.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Detail_Component(int id)
        {
            var certificateComponent = await unitOfWork.CertificateComponent.GetAsync(id);
            if (certificateComponent != null)
                return View(certificateComponent);
            return NotFound();
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> Delete_Component(int? id)
        {
            if (id != null)
            {
                var certificateComponent = await unitOfWork.CertificateComponent.GetAsync(id);
                if (certificateComponent != null)
                {
                    fileService.Delete(certificateComponent.PhotoName);
                    fileService.Delete(certificateComponent.FileName_AZ);
                    fileService.Delete(certificateComponent.FileName_EN);
                    fileService.Delete(certificateComponent.FileName_RU);
                    await unitOfWork.CertificateComponent.DeleteAsync(id);
                    await unitOfWork.CommitAsync();
                    return Ok();
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete_File(int? id)
        {
            if (id != null)
            {
                var file = await unitOfWork.CertificateComponentFile.GetAsync(id);
                if (file != null)
                {
                    await unitOfWork.CertificateComponentFile.DeleteAsync(id);
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
