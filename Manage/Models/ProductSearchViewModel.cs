using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class ProductSearchViewModel
    {
        public bool All { get; set; }

        public ProductTitleCategoryFilter[] ProductTitleCategoriesForFilter { get; set; }
    }
}
