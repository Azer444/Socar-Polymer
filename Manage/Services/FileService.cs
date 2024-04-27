using Microsoft.AspNetCore.Http;
using Syncfusion.Pdf;
using Syncfusion.XlsIO;
using Syncfusion.XlsIORenderer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Services
{
    public class FileService : IFileService
    {
        public async Task<string> UploadAsync(IFormFile file, string savePath = "uploads")
        {
            string filename = Guid.NewGuid() + "_" + file.FileName;

            var writePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", savePath);
            if (!Directory.Exists(writePath))
                Directory.CreateDirectory(writePath);

            var path = Path.Combine(writePath, filename);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return filename;
        }

        public async Task<string> ExcelToPDF(IFormFile file, string savePath = "uploads")
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(file.OpenReadStream());
                IWorksheet worksheet = workbook.Worksheets[0];
                //Initialize XlsIO renderer.
                XlsIORenderer renderer = new XlsIORenderer();
                //Convert Excel document into PDF document
                PdfDocument pdfDocument = renderer.ConvertToPDF(worksheet);

                var writePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", savePath);
                if (!Directory.Exists(writePath))
                    Directory.CreateDirectory(writePath);

                string filename = Guid.NewGuid() + "_" + Path.GetFileNameWithoutExtension(file.FileName) + ".pdf";
                var path = Path.Combine(writePath, filename);

                Stream stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
                pdfDocument.Save(stream);
                stream.Dispose();

                return filename;
            }
        }

        public void Delete(string filename)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                string path = Path.Combine(
                                   Directory.GetCurrentDirectory(), "wwwroot", "uploads",
                                   filename);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
        }
    }
}
