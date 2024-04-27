using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class SubComponentViewModel
    {
        public HeaderPartialViewModel HeaderPartialViewModel { get; set; }

        public MarketSubComponent MarketSubComponent { get; set; }

        public FooterPartialViewModel FooterPartialViewModel { get; set; }
    }
}
