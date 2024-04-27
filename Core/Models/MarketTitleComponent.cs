using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class MarketTitleComponent
    {
        public int Id { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }

        [Display(Name = "Nav Title Component")]
        public NavTitleComponent NavTitleComponent { get; set; }

        public int NavTitleComponentId { get; set; }


        [Display(Name ="Photo")]
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

        [Display(Name = "Components")]
        public ICollection<MarketComponent> MarketComponents { get; set; }

        [Display(Name ="Files")]
        public ICollection<MarketTitleComponentFile> MarketTitleComponentFiles { get; set; }
    }
}
