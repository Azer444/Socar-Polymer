using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class ProductBrochure
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }

        public string Name { get; set; }
    }
}
