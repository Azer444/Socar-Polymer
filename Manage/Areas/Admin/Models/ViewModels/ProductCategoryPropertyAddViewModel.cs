using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Areas.Admin.Models.ViewModels
{
    public class ProductCategoryPropertyAddViewModel
    {
        [Display(Name = "Name (AZ)")]
        public string Name_AZ { get; set; }

        [Display(Name = "Name (RU)")]
        public string Name_RU { get; set; }

        [Required]
        [Display(Name = "Name (EN)")]
        public string Name_EN { get; set; }

        public int ProductCategoryId { get; set; }
    }
}
