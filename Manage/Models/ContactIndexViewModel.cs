using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class ContactIndexViewModel
    {
        public HeaderPartialViewModel HeaderPartialViewModel { get; set; }

        public ContactTextComponent ContactTextComponent { get; set; }

        public ContactFormComponent ContactFormComponent { get; set; }

        public FooterPartialViewModel FooterPartialViewModel { get; set; }
    }
}
