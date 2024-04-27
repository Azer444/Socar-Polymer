using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Services
{
    public interface IFileService
    {
        Task<string> UploadAsync(IFormFile file, string savePath = "uploads");
        Task<string> ExcelToPDF(IFormFile file, string savePath = "uploads");
        void Delete(string filename);
    }
}
