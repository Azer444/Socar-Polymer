using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class NewsViewModel
    {
        public HeaderPartialViewModel HeaderPartialViewModel { get; set; }

        public List<News> News { get; set; }

        public News News_ { get; set; }

        public FooterPartialViewModel FooterPartialViewModel { get; set; }
    }
}
