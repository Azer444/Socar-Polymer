using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class MarketComponent
    {
        public int Id { get; set; }

        [Display(Name = "Market Title Component")]
        public MarketTitleComponent MarketTitleComponent { get; set; }

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
        [Display(Name = "Slug")]
        public string Slug { get; set; }

        [Required]
        [Display(Name = "Content (AZ)")]
        public string Content_AZ { get; set; }

        [Required]
        [Display(Name = "Content (RU)")]
        public string Content_RU { get; set; }

        [Required]
        [Display(Name = "Content (EN)")]
        public string Content_EN { get; set; }

        [Display(Name = "Photo")]
        public string PhotoName { get; set; }

        [Display(Name ="Sub Components")]
        public ICollection<MarketSubComponent> MarketSubComponents { get; set; }

        [Display(Name = "Files")]
        public ICollection<MarketComponentFile> MarketComponentFiles { get; set; }
    }
}
