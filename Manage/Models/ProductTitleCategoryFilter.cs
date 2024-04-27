using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class ProductTitleCategoryFilter
    {
        public int Id { get; set; }
        public string Name_AZ { get; set; }
        public string Name_RU { get; set; }
        public string Name_EN { get; set; }

        public ProductCategoryFilter[] Categories { get; set; }

        public bool Selected { get; set; }
    }
}
