using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class ComponentViewModel
    {
        public HeaderPartialViewModel HeaderPartialViewModel { get; set; }
        public FooterPartialViewModel FooterPartialViewModel { get; set; }
        public MarketComponent MarketComponent { get; set; }
    }
}
