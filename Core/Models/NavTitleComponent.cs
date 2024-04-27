using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Models
{
    public class NavTitleComponent
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title (AZ)")]
        public string Title_AZ { get; set; }

        [Required]
        [Display(Name = "Title (RU)")]
        public string Title_RU { get; set; }

        [Required]
        [Display(Name = "Title (EN)")]
        public string Title_EN { get; set; }


        [Display(Name = "Content (AZ)")]
        public string Content_AZ { get; set; }

        [Display(Name = "Content (RU)")]
        public string Content_RU { get; set; }

        [Display(Name = "Content (EN)")]
        public string Content_EN { get; set; }
        public string Link { get; set; }

        [Required]
        [Display(Name = "Has Main Component on Home Page")]
        public bool HasMainComponent { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public string PhotoName { get; set; }

        public ICollection<MarketTitleComponent> MarketTitleComponents { get; set; }

        public ICollection<CertificateComponent> CertificateComponents { get; set; }

        public ICollection<NavComponent> NavComponents { get; set; }
    }
}
