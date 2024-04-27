using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ProductTitleCategory
    {
        public ProductTitleCategory()
        {
            ProductCategories = new List<ProductCategory>();
        }

        public int Id { get; set; }

        //[Required]
        [Display(Name = "Name (AZ)")]
        public string Name_AZ { get; set; }

        //[Required]
        [Display(Name = "Name (RU)")]
        public string Name_RU { get; set; }

        [Required]
        [Display(Name = "Name (EN)")]
        public string Name_EN { get; set; }

        [Display(Name = "Categories")]
        public IList<ProductCategory> ProductCategories { get; set; }
    }
}
