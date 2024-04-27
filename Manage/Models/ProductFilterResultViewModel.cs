using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class ProductFilterResultViewModel
    {
        public ProductFilterResultViewModel()
        {
            ProductTitleCategories = new List<ProductTitleCategoryMap>();
        }

        public int Count { get; set; }
        public List<ProductTitleCategoryMap> ProductTitleCategories { get; set; }
    }
}
