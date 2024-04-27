using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class ProductTitleCategoryMap
    {
        public ProductTitleCategoryMap()
        {
            ProductCategories = new List<ProductCategoryMap>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<ProductCategoryMap> ProductCategories { get; set; }
    }
}
