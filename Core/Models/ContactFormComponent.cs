using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Models
{
    public class ContactFormComponent
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

        [Required]
        [Display(Name = "Subtitle 1 (AZ)")]
        public string Subtitle_1_AZ { get; set; }

        [Required]
        [Display(Name = "Subtitle 1 (RU)")]
        public string Subtitle_1_RU { get; set; }

        [Required]
        [Display(Name = "Subtitle 1 (EN)")]
        public string Subtitle_1_EN { get; set; }

        [Required]
        [Display(Name = "Subtitle 2 (AZ)")]
        public string Subtitle_2_AZ { get; set; }

        [Required]
        [Display(Name = "Subtitle 2 (RU)")]
        public string Subtitle_2_RU { get; set; }

        [Required]
        [Display(Name = "Subtitle 2 (EN)")]
        public string Subtitle_2_EN { get; set; }

        [Required]
        [Display(Name = "Subtitle 3 (AZ)")]
        public string Subtitle_3_AZ { get; set; }

        [Required]
        [Display(Name = "Subtitle 3 (RU)")]
        public string Subtitle_3_RU { get; set; }

        [Required]
        [Display(Name = "Subtitle 3 (EN)")]
        public string Subtitle_3_EN { get; set; }

        [Required]
        [Display(Name = "Subtitle 4 (AZ)")]
        public string Subtitle_4_AZ { get; set; }

        [Required]
        [Display(Name = "Subtitle 4 (RU)")]
        public string Subtitle_4_RU { get; set; }

        [Required]
        [Display(Name = "Subtitle 4 (EN)")]
        public string Subtitle_4_EN { get; set; }

        [Required]
        [Display(Name = "Error Message (AZ)")]
        public string ErrorMessage_AZ { get; set; }

        [Required]
        [Display(Name = "Error Message (RU)")]
        public string ErrorMessage_RU { get; set; }

        [Required]
        [Display(Name = "Error Message (EN)")]
        public string ErrorMessage_EN { get; set; }

        [Required]
        [Display(Name = "Success Message (AZ)")]
        public string SuccessMessage_AZ { get; set; }

        [Required]
        [Display(Name = "Success Message (RU)")]
        public string SuccessMessage_RU { get; set; }

        [Required]
        [Display(Name = "Success Message (EN)")]
        public string SuccessMessage_EN { get; set; }

        [Required]
        [Display(Name = "Button Text (AZ)")]
        public string ButtonText_AZ { get; set; }

        [Required]
        [Display(Name = "Button Text (RU)")]
        public string ButtonText_RU { get; set; }

        [Required]
        [Display(Name = "Button Text (EN)")]
        public string ButtonText_EN { get; set; }
    }
}
