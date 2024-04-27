using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class MarketIndexViewModel
    {
        public HeaderPartialViewModel HeaderPartialViewModel { get; set; }

        public List<MarketTitleComponent> MarketTitleComponents { get; set; }

        public FooterPartialViewModel FooterPartialViewModel { get; set; }
    }
}
