using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CertificateComponent
    {
        public int Id { get; set; }

        public NavTitleComponent NavTitleComponent { get; set; }

        public int NavTitleComponentId { get; set; }

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

        public string PhotoName { get; set; }
        public string FileName_AZ { get; set; }
        public string FileName_EN { get; set; }
        public string FileName_RU { get; set; }

        [Display(Name = "Certificate Component Files")]
        public ICollection<CertificateComponentFile> CertificateComponentFiles { get; set; }
    }
}
