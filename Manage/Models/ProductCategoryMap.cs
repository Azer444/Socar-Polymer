using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class ProductCategoryMap
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ProductTitleCategoryMap ProductTitleCategory { get; set; }

        public int ProductTitleCategoryId { get; set; }

        public ICollection<ProductCategoryPropertyMap> ProductCategoryProperties { get; set; }

        public ICollection<ProductMap> Products { get; set; }
    }
}
