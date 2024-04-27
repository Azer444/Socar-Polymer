using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class TitleComponentViewModel
    {
        public HeaderPartialViewModel HeaderPartialViewModel { get; set; }
        public FooterPartialViewModel FooterPartialViewModel { get; set; }
        public MarketTitleComponent MarketTitleComponent { get; set; }
    }
}
