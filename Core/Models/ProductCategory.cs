using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }

        [Display(Name = "Name (AZ)")]
        public string Name_AZ { get; set; }

        [Display(Name = "Name (RU)")]
        public string Name_RU { get; set; }

        [Required]
        [Display(Name = "Name (EN)")]
        public string Name_EN { get; set; }

        [Display(Name = "Title Category")]
        public ProductTitleCategory ProductTitleCategory { get; set; }

        public int ProductTitleCategoryId { get; set; }

        [Display(Name="Properties")]
        public IList<ProductCategoryProperty> ProductCategoryProperties { get; set; }

        [Display(Name = "Products")]
        public ICollection<Product> Products { get; set; }
    }
}
