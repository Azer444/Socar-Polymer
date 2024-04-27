using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Areas.Admin.Models.ViewModels
{
    public class CertificateComponentAddViewModel
    {
        public CertificateComponentAddViewModel()
        {
        }

        [Required]
        [Display(Name = "Title (AZ)")]
        public string Title_AZ { get; set; }

        [Required]
        [Display(Name = "Title (RU)")]
        public string Title_RU { get; set; }

        [Required]
        [Display(Name = "Title (EN)")]
        public string Title_EN { get; set; }

        public string Slug { get; set; }


        [Display(Name = "Content (AZ)")]
        public string Content_AZ { get; set; }


        [Display(Name = "Content (RU)")]
        public string Content_RU { get; set; }


        [Display(Name = "Content (EN)")]
        public string Content_EN { get; set; }

        [Required]
        public IFormFile Photo { get; set; }

        public IFormFile File_AZ { get; set; }

        public IFormFile File_EN { get; set; }

        public IFormFile File_RU { get; set; }

        public List<SelectListItem> NavTitleComponents { get; set; }
        public int NavTitleComponentId { get; set; }
    }
}
