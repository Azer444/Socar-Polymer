using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Models;
using Manage.Areas.Admin.Models.ViewModels;
using Manage.Helpers;
using Manage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Manage.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Manager, Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IFileService fileService;

        public ProductController(IUnitOfWork unitOfWork,
            IFileService fileService)
        {
            this.unitOfWork = unitOfWork;
            this.fileService = fileService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var productCategories = await unitOfWork.ProductTitleCategory.GetAllAsync();
            return View(productCategories);
        }

        [HttpGet]
        public IActionResult Add_Title_Category()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add_Title_Category(ProductTitleCategory productTitleCategory)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.ProductTitleCategory.CreateAsnyc(productTitleCategory);
                await unitOfWork.CommitAsync();

                return RedirectToAction("index");
            }

            return View(productTitleCategory);
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Title_Category(int? id)
        {
            if (id != null)
            {
                var productTitleCategory = await unitOfWork.ProductTitleCategory.GetAsync(id);
                if (productTitleCategory != null)
                {
                    return View(productTitleCategory);
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit_Title_Category(ProductTitleCategory productTitleCategory)
        {
            if (ModelState.IsValid)
            {
                var productTitleCategory_ = await unitOfWork.ProductTitleCategory.GetAsync(productTitleCategory.Id);
                if (productTitleCategory_ != null)
                {
                    productTitleCategory_.Name_AZ = productTitleCategory.Name_AZ;
                    productTitleCategory_.Name_RU = productTitleCategory.Name_RU;
                    productTitleCategory_.Name_EN = productTitleCategory.Name_EN;

                    await unitOfWork.ProductTitleCategory.UpdateAsync(productTitleCategory_);
                    await unitOfWork.CommitAsync();

                    return RedirectToAction("index");
                }

                return NotFound();
            }

            return View(productTitleCategory);
        }

        [HttpGet]
        public async Task<IActionResult> Detail_Title_Category(int? id)
        {
            if (id != null)
            {
                var productTitleCategory = await unitOfWork.ProductTitleCategory.GetAsync(id);
                if (productTitleCategory != null)
                    return View(productTitleCategory);
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete_Title_Category(int? id)
        {
            if (id != null)
            {
                var productTitleCategory = await unitOfWork.ProductTitleCategory.GetAsync(id);
                if (productTitleCategory != null)
                {
                    await unitOfWork.ProductTitleCategory.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Add_Category(int? id)
        {
            var productTitleCategory = await unitOfWork.ProductTitleCategory.GetAsync(id);
            if (productTitleCategory != null)
                return View();

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Add_Category(ProductCategory productCategory)
        {
            if (ModelState.IsValid)
            {
                var productTitleCategory = await unitOfWork.ProductTitleCategory.GetAsync(productCategory.ProductTitleCategoryId);
                if (productTitleCategory != null)
                {
                    await unitOfWork.ProductCategory.CreateAsnyc(productCategory);
                    await unitOfWork.CommitAsync();

                    return RedirectToAction("detail_title_category", "product", new { id = productCategory.ProductTitleCategoryId });
                }

                return NotFound();
            }

            return View(productCategory);
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Category(int? id)
        {
            if (id != null)
            {
                var productCategory = await unitOfWork.ProductCategory.GetAsync(id);
                if (productCategory != null)
                {
                    return View(productCategory);
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit_Category(ProductCategory productCategory)
        {
            if (ModelState.IsValid)
            {
                var productCategory_ = await unitOfWork.ProductCategory.GetAsync(productCategory.Id);
                if (productCategory_ != null)
                {
                    productCategory_.Name_AZ = productCategory.Name_AZ;
                    productCategory_.Name_RU = productCategory.Name_RU;
                    productCategory_.Name_EN = productCategory.Name_EN;

                    await unitOfWork.ProductCategory.UpdateAsync(productCategory_);
                    await unitOfWork.CommitAsync();

                    return RedirectToAction("detail_title_category", "product", new { id = productCategory_.ProductTitleCategoryId });
                }

                return NotFound();
            }

            return View(productCategory);
        }

        [HttpGet]
        public async Task<IActionResult> Detail_Category(int? id)
        {
            if (id != null)
            {
                var productCategory = await unitOfWork.ProductCategory.GetAsync(id);
                if (productCategory != null)
                    return View(productCategory);
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete_Category(int? id)
        {
            if (id != null)
            {
                var productCategory = await unitOfWork.ProductCategory.GetAsync(id);

                if (productCategory != null)
                {
                    await unitOfWork.ProductCategory.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Add_Property(int? id)
        {
            var category = await unitOfWork.ProductCategory.GetAsync(id);
            if (category != null)
                return View();

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Add_Property(ProductCategoryPropertyAddViewModel model)
        {
            var productCategory = await unitOfWork.ProductCategory.GetAsync(model.ProductCategoryId);
            if (productCategory == null) return NotFound();

            var productCategoryProperty = new ProductCategoryProperty
            {
                Name_AZ = model.Name_AZ,
                Name_RU = model.Name_RU,
                Name_EN = model.Name_EN,
                ProductCategoryId = productCategory.Id
            };

            await unitOfWork.ProductCategoryProperty.CreateAsnyc(productCategoryProperty);
            await unitOfWork.CommitAsync();

            return RedirectToAction("detail_category", "product", new { id = model.ProductCategoryId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Property(int? id)
        {
            var productCategoryProperty = await unitOfWork.ProductCategoryProperty.GetAsync(id);
            if (productCategoryProperty == null) return NotFound();
            
            var model = new ProductCategoryPropertyEditViewModel
            {
                Name_AZ = productCategoryProperty.Name_AZ,
                Name_RU = productCategoryProperty.Name_RU,
                Name_EN = productCategoryProperty.Name_EN
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit_Property(ProductCategoryPropertyEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var productCategoryProperty = await unitOfWork.ProductCategoryProperty.GetAsync(model.Id);
                if (productCategoryProperty == null) return NotFound();

                productCategoryProperty.Name_AZ = model.Name_AZ;
                productCategoryProperty.Name_RU = model.Name_RU;
                productCategoryProperty.Name_EN = model.Name_EN;

                await unitOfWork.ProductCategoryProperty.UpdateAsync(productCategoryProperty);
                await unitOfWork.CommitAsync();

                return RedirectToAction("detail_category", "product", new { id = productCategoryProperty.ProductCategoryId });
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete_Property(int? id)
        {
            var property = await unitOfWork.ProductCategoryProperty.GetAsync(id);
            if (property == null) return NotFound();

            await unitOfWork.ProductCategoryProperty.DeleteAsync(id);
            await unitOfWork.CommitAsync();

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Add_Component(int? id)
        {
            var category = await unitOfWork.ProductCategory.GetAsync(id);
            if (category != null)
            {
                ViewBag.Properties = category.ProductCategoryProperties.ToList();
                return View();
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Add_Component(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.TDSFile_AZ != null)
                {
                    if (Path.GetExtension(product.TDSFile_AZ.FileName) == ".xls" || Path.GetExtension(product.TDSFile_AZ.FileName) == ".xlsx")
                        product.TDSName_AZ = await fileService.ExcelToPDF(product.TDSFile_AZ);
                    else
                        product.TDSName_AZ = await fileService.UploadAsync(product.TDSFile_AZ);
                }
                if (product.TDSFile_RU != null)
                {
                    if (Path.GetExtension(product.TDSFile_RU.FileName) == ".xls" || Path.GetExtension(product.TDSFile_RU.FileName) == ".xlsx")
                        product.TDSName_RU = await fileService.ExcelToPDF(product.TDSFile_RU);
                    else
                        product.TDSName_RU = await fileService.UploadAsync(product.TDSFile_RU);
                }
                if (product.TDSFile_EN != null)
                {
                    if (Path.GetExtension(product.TDSFile_EN.FileName) == ".xls" || Path.GetExtension(product.TDSFile_EN.FileName) == ".xlsx")
                        product.TDSName_EN = await fileService.ExcelToPDF(product.TDSFile_EN);
                    else
                        product.TDSName_EN = await fileService.UploadAsync(product.TDSFile_EN);
                }

                if (product.SDSFile_AZ != null)
                {
                    if (Path.GetExtension(product.SDSFile_AZ.FileName) == ".xls" || Path.GetExtension(product.SDSFile_AZ.FileName) == ".xlsx")
                        product.SDSName_AZ = await fileService.ExcelToPDF(product.SDSFile_AZ);
                    else
                        product.SDSName_AZ = await fileService.UploadAsync(product.SDSFile_AZ);
                }
                if (product.SDSFile_RU != null)
                {
                    if (Path.GetExtension(product.SDSFile_RU.FileName) == ".xls" || Path.GetExtension(product.SDSFile_RU.FileName) == ".xlsx")
                        product.SDSName_RU = await fileService.ExcelToPDF(product.SDSFile_RU);
                    else
                        product.SDSName_RU = await fileService.UploadAsync(product.SDSFile_RU);
                }
                if (product.SDSFile_EN != null)
                {
                    if (Path.GetExtension(product.SDSFile_EN.FileName) == ".xls" || Path.GetExtension(product.SDSFile_EN.FileName) == ".xlsx")
                        product.SDSName_EN = await fileService.ExcelToPDF(product.SDSFile_EN);
                    else
                        product.SDSName_EN = await fileService.UploadAsync(product.SDSFile_EN);
                }

                await unitOfWork.Product.CreateAsnyc(product);
                await unitOfWork.CommitAsync();

                foreach (var brochure in product.Brochures)
                {
                    var productBrochure = new ProductBrochure
                    {
                        Name = await fileService.UploadAsync(brochure),
                        ProductId = product.Id
                    };

                    await unitOfWork.ProductBrochure.CreateAsnyc(productBrochure);
                    await unitOfWork.CommitAsync();
                }
                return RedirectToAction("detail_category", "product", new { id = product.ProductCategoryId });
            }

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Details_Component(int? id)
        {
            if (id != null)
            {
                var product = await unitOfWork.Product.GetAsync(id);
                if (product != null)
                {
                    ViewBag.Properties = product.ProductCategory.ProductCategoryProperties.ToList();
                    return View(product);
                }
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Component(int? id)
        {
            if (id != null)
            {
                var product = await unitOfWork.Product.GetAsync(id);
                if (product != null)
                {
                    ViewBag.Properties = product.ProductCategory.ProductCategoryProperties.ToList();
                    return View(product);
                }
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit_Component(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.TDSFile_AZ != null)
                {
                    if (Path.GetExtension(product.TDSFile_AZ.FileName) == ".xls" || Path.GetExtension(product.TDSFile_AZ.FileName) == ".xlsx")
                        product.TDSName_AZ = await fileService.ExcelToPDF(product.TDSFile_AZ);
                    else
                        product.TDSName_AZ = await fileService.UploadAsync(product.TDSFile_AZ);
                }
                if (product.TDSFile_RU != null)
                {
                    if (Path.GetExtension(product.TDSFile_RU.FileName) == ".xls" || Path.GetExtension(product.TDSFile_RU.FileName) == ".xlsx")
                        product.TDSName_RU = await fileService.ExcelToPDF(product.TDSFile_RU);
                    else
                        product.TDSName_RU = await fileService.UploadAsync(product.TDSFile_RU);
                }
                if (product.TDSFile_EN != null)
                {
                    if (Path.GetExtension(product.TDSFile_EN.FileName) == ".xls" || Path.GetExtension(product.TDSFile_EN.FileName) == ".xlsx")
                        product.TDSName_EN = await fileService.ExcelToPDF(product.TDSFile_EN);
                    else
                        product.TDSName_EN = await fileService.UploadAsync(product.TDSFile_EN);
                }

                if (product.SDSFile_AZ != null)
                {
                    if (Path.GetExtension(product.SDSFile_AZ.FileName) == ".xls" || Path.GetExtension(product.SDSFile_AZ.FileName) == ".xlsx")
                        product.SDSName_AZ = await fileService.ExcelToPDF(product.SDSFile_AZ);
                    else
                        product.SDSName_AZ = await fileService.UploadAsync(product.SDSFile_AZ);
                }
                if (product.SDSFile_RU != null)
                {
                    if (Path.GetExtension(product.SDSFile_RU.FileName) == ".xls" || Path.GetExtension(product.SDSFile_RU.FileName) == ".xlsx")
                        product.SDSName_RU = await fileService.ExcelToPDF(product.SDSFile_RU);
                    else
                        product.SDSName_RU = await fileService.UploadAsync(product.SDSFile_RU);
                }
                if (product.SDSFile_EN != null)
                {
                    if (Path.GetExtension(product.SDSFile_EN.FileName) == ".xls" || Path.GetExtension(product.SDSFile_EN.FileName) == ".xlsx")
                        product.SDSName_EN = await fileService.ExcelToPDF(product.SDSFile_EN);
                    else
                        product.SDSName_EN = await fileService.UploadAsync(product.SDSFile_EN);
                }

                await unitOfWork.Product.UpdateAsync(product);
                await unitOfWork.CommitAsync();

                foreach (var productField in product.ProductFields)
                {
                    await unitOfWork.ProductField.UpdateAsync(productField);
                    await unitOfWork.CommitAsync();
                }

                foreach (var brochure in product.Brochures)
                {
                    var productBrochure = new ProductBrochure
                    {
                        Name = await fileService.UploadAsync(brochure),
                        ProductId = product.Id
                    };

                    await unitOfWork.ProductBrochure.CreateAsnyc(productBrochure);
                    await unitOfWork.CommitAsync();
                }

                return RedirectToAction("details_component", "product", new { id = product.Id });
            }

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Delete_Component(int? id)
        {
            if (id != null)
            {
                var product = await unitOfWork.Product.GetAsync(id);
                if (product != null)
                {
                    await unitOfWork.Product.DeleteAsync(id);
                    await unitOfWork.CommitAsync();

                    return Ok();
                }
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Contact()
        {
            var productContactMessages = await unitOfWork.ProductContactMessage.GetAllAsync();
            return View(productContactMessages);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsContact(int id)
        {
            var productContactMessage = await unitOfWork.ProductContactMessage.GetAsync(id);
            if (productContactMessage == null) return NotFound();

            return View(productContactMessage);
        }
    }
}
