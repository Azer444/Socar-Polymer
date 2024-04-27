using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class MarketSubComponent
    {
        public int Id { get; set; }

        [Display(Name = "Market Component")]
        public MarketComponent MarketComponent { get; set; }

        public int MarketComponentId { get; set; }

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

        [Required]
        [Display(Name = "Content (AZ)")]
        public string Content_AZ { get; set; }

        [Required]
        [Display(Name = "Content (RU)")]
        public string Content_RU { get; set; }

        [Required]
        [Display(Name = "Content (EN)")]
        public string Content_EN { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public string PhotoName { get; set; }


        [Display(Name ="Market SubComponent Files")]
        public ICollection<MarketSubComponentFile> MarketSubComponentFiles { get; set; }

        [NotMapped]
        public List<IFormFile> Files { get; set; }
    }
}
