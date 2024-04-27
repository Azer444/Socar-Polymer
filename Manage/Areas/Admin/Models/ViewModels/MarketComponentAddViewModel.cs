using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Areas.Admin.Models.ViewModels
{
    public class MarketComponentAddViewModel
    {
        public MarketComponentAddViewModel()
        {
            Files = new List<IFormFile>();
        }

        public int Id { get; set; }

        public int MarketTitleComponentId { get; set; }

        [Required]
        [Display(Name = "Title (AZ)")]
        public string Title_AZ { get; set; }

        [Required]
        [Display(Name = "Title (RU)")]
        public string Title_RU { get; set; }

        [Required]
        [Display(Name = "Title (EN)")]
        public string Title_EN { get; set; }

        [Required]
        [Display(Name = "Content (AZ)")]
        public string Content_AZ { get; set; }

        [Required]
        [Display(Name = "Content (RU)")]
        public string Content_RU { get; set; }

        [Required]
        [Display(Name = "Content (EN)")]
        public string Content_EN { get; set; }

        [Required]
        [Display(Name = "Slug")]
        public string Slug { get; set; }

        [Required]
        public IFormFile Photo { get; set; }

        public string PhotoName { get; set; }

        public List<IFormFile> Files { get; set; }

    }
}
