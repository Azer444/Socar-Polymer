using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class CertificatesDetailsViewModel
    {
        public HeaderPartialViewModel HeaderPartialViewModel { get; set; }

        public CertificateComponent CertificateComponent { get; set; }

        public FooterPartialViewModel FooterPartialViewModel { get; set; }
    }
}
