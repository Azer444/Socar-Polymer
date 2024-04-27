using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class ProductViewModel
    {
        public HeaderPartialViewModel HeaderPartialViewModel { get; set; }

        public int Count { get; set; }

        public List<ProductTitleCategory> ProductTitleCategories { get; set; }

        public ProductSearchViewModel ProductSearchViewModel { get; set; }

        public FooterPartialViewModel FooterPartialViewModel { get; set; }
    }
}
