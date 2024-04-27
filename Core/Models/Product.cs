using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Product
    {
        public Product()
        {
            ProductFields = new List<ProductField>();
            Brochures = new List<IFormFile>();
        }

        public int Id { get; set; }

        [NotMapped]
        [Display(Name = "TDS File (AZ)")]
        public IFormFile TDSFile_AZ { get; set; }

        public string TDSName_AZ { get; set; }

        [NotMapped]
        [Display(Name = "TDS File (RU)")]
        public IFormFile TDSFile_RU { get; set; }

        public string TDSName_RU { get; set; }

        [NotMapped]
        [Display(Name = "TDS File (EN)")]
        public IFormFile TDSFile_EN { get; set; }

        public string TDSName_EN { get; set; }


        [NotMapped]
        [Display(Name = "SDS File")]
        public IFormFile SDSFile_AZ { get; set; }

        public string SDSName_AZ { get; set; }

        [NotMapped]
        [Display(Name = "SDS File")]
        public IFormFile SDSFile_RU { get; set; }

        public string SDSName_RU { get; set; }

        [NotMapped]
        [Display(Name = "SDS File")]
        public IFormFile SDSFile_EN { get; set; }

        public string SDSName_EN { get; set; }

        public ProductCategory ProductCategory { get; set; }

        public int ProductCategoryId { get; set; }

        [Display(Name = "Product Fields")]
        public IList<ProductField> ProductFields { get; set; }

        [Display(Name = "Product Brochures")]
        public ICollection<ProductBrochure> ProductBrochures { get; set; }

        [NotMapped]
        public List<IFormFile> Brochures { get; set; }
    }
}
