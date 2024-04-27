using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class CertificatesIndexViewModel
    {
        public HeaderPartialViewModel HeaderPartialViewModel { get; set; }

        public List<CertificateComponent> CertificateComponents { get; set; }

        public FooterPartialViewModel FooterPartialViewModel { get; set; }
    }
}
