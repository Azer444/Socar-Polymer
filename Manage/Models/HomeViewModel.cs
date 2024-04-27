using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class HomeViewModel
    {
        public HeaderPartialViewModel HeaderPartialViewModel { get; set; }

        public FooterPartialViewModel FooterPartialViewModel { get; set; }

        public HomeBannerComponent HomeBannerComponent { get; set; }

        public List<HomeSliderComponent> HomeSliderComponents { get; set; }

        public List<NavTitleComponent> NavTitleHomeComponents { get; set; }
    }
}
