using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class News
    {
        public News()
        {
            Files = new List<IFormFile>();
        }
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

        [Required]
        [NotMapped]
        public IFormFile Photo { get; set; }

        public string PhotoName { get; set; }

        [Display(Name = "Files")]
        public ICollection<NewsFile> NewsFiles { get; set; }

        [NotMapped]
        public List<IFormFile> Files { get; set; }

        [Display(Name = "Created at")]
        public DateTime CreatedAt { get; set; }
    }
}
