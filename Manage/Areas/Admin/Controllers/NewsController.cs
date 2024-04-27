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
    public class NewsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IFileService fileService;

        public NewsController(IUnitOfWork unitOfWork,
            IFileService fileService)
        {
            this.unitOfWork = unitOfWork;
            this.fileService = fileService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var news = await unitOfWork.News.GetAllAsync();
            return View(news);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(News news)
        {
            if (ModelState.IsValid)
            {
                news.PhotoName = await fileService.UploadAsync(news.Photo);
                await unitOfWork.News.CreateAsnyc(news);
                await unitOfWork.CommitAsync();

                foreach (var file in news.Files)
                {
                    var file_ = new NewsFile()
                    {
                        NewsId = news.Id,
                        FileName = await fileService.UploadAsync(file),
                        DisplayName = file.FileName
                    };

                    await unitOfWork.NewsFile.CreateAsnyc(file_);
                    await unitOfWork.CommitAsync();
                }

                return RedirectToAction("index", "news");
            }

            return View(news);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var news = await unitOfWork.News.GetAsync(id);
                if (news != null)
                {
                    var model = new NewsEditViewModel
                    {
                        Title_AZ = news.Title_AZ,
                        Title_RU = news.Title_RU,
                        Title_EN = news.Title_EN,
                        Content_AZ = news.Content_AZ,
                        Content_RU = news.Content_RU,
                        Content_EN = news.Content_EN,
                        Slug = news.Slug,
                        CreatedAt = news.CreatedAt,
                        PhotoName = news.PhotoName,
                        NewsFiles = news.NewsFiles
                    };

                    return View(model);
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NewsEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var news = await unitOfWork.News.GetAsync(model.Id);
                if (news != null)
                {
                    news.Title_AZ = model.Title_AZ;
                    news.Title_RU = model.Title_RU;
                    news.Title_EN = model.Title_EN;
                    news.Slug = model.Slug;
                    news.Content_AZ = model.Content_AZ;
                    news.Content_RU = model.Content_RU;
                    news.Content_EN = model.Content_EN;

                    if (model.Photo != null)
                        news.PhotoName = await fileService.UploadAsync(model.Photo);

                    foreach (var file in model.Files)
                    {
                        var file_ = new NewsFile()
                        {
                            NewsId = news.Id,
                            FileName = await fileService.UploadAsync(file),
                            DisplayName = file.FileName
                        };

                        await unitOfWork.NewsFile.CreateAsnyc(file_);
                        await unitOfWork.CommitAsync();
                    }

                    await unitOfWork.News.UpdateAsync(news);
                    await unitOfWork.CommitAsync();

                    return RedirectToAction("detail", "news", new { id = news.Id });
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id != null)
            {
                var news = await unitOfWork.News.GetAsync(id);
                if (news != null)
                    return View(news);
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                var news = await unitOfWork.News.GetAsync(id);
                if (news != null)
                {
                    foreach (var newsFile in news.NewsFiles)
                        fileService.Delete(newsFile.FileName);

                    await unitOfWork.News.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete_File(int? id)
        {
            if (id != null)
            {
                var file = await unitOfWork.NewsFile.GetAsync(id);
                if (file != null)
                {
                    await unitOfWork.NewsFile.DeleteAsync(id);
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
