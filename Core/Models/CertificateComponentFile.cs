using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CertificateComponentFile
    {
        public int Id { get; set; }

        [Required]
        public string DisplayName_EN { get; set; }
        public string DisplayName_RU { get; set; }

        [Required]
        public string FileName_EN { get; set; }
        public string FileName_RU { get; set; }

        public CertificateComponent CertificateComponent { get; set; }

        public int CertificateComponentId { get; set; }
    }
}
