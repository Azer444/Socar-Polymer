using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Areas.Admin.Models.ViewModels
{
    public class HomeViewModel
    {
        public HomeBannerComponent HomeBannerComponent { get; set; }

        public List<HomeSliderComponent> HomeSliderComponents { get; set; }
    }
}
