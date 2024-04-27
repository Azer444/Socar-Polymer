using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class ProductDetailsViewModel
    {
        public HeaderPartialViewModel HeaderPartialViewModel { get; set; }

        public Product Product { get; set; }

        public ProductContactFormModel ProductContactFormModel { get; set; }

        public FooterPartialViewModel FooterPartialViewModel { get; set; }
    }
}
