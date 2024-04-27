using Core.Models;
using Manage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Areas.Admin.Models.ViewModels
{
    public class ContactIndexViewModel
    {
        public ContactTextComponent ContactTextComponent { get; set; }

        public ContactFormComponent ContactFormComponent { get; set; }
    }
}
