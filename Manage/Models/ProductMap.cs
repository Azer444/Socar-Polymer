using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class ProductMap
    {
        public int Id { get; set; }

        public string TDSName { get; set; }

        public string SDSName { get; set; }

        public ProductCategoryMap ProductCategory { get; set; }

        public int ProductCategoryId { get; set; }

        public IList<ProductFieldMap> ProductFields { get; set; }

        public ICollection<ProductBrochure> ProductBrochures { get; set; }
    }
}
