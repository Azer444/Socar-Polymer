using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Areas.Admin.Models.ViewModels
{
    public class MarketTitleComponentAddViewModel
    {
        public MarketTitleComponentAddViewModel()
        {
            Files = new List<IFormFile>();
        }

        [Required]
        [NotMapped]
        public IFormFile Photo { get; set; }

        [Display(Name = "Photo")]
        public string PhotoName { get; set; }

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
        public string Slug { get; set; }


        [Display(Name = "Content (AZ)")]
        public string Content_AZ { get; set; }

        [Display(Name = "Content (RU)")]
        public string Content_RU { get; set; }

        [Display(Name = "Content (EN)")]
        public string Content_EN { get; set; }


        [Display(Name = "Location")]
        public int LocationId { get; set; }
        public List<SelectListItem> Locations { get; set; }

        [Display(Name = "Nav Title Component")]
        public int NavTitleComponentId { get; set; }
        public List<SelectListItem> NavTitleComponents { get; set; }

        public List<IFormFile> Files { get; set; }
    }
}
