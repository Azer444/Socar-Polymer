using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Models
{
    public class NavComponent
    {
        public int Id { get; set; }

        public int NavTitleComponentId { get; set; }

        public NavTitleComponent NavTitleComponent { get; set; }

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
    }
}
