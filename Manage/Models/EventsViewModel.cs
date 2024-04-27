using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class EventsViewModel
    {
        public HeaderPartialViewModel HeaderPartialViewModel { get; set; }

        public List<Event> Events { get; set; }

        public Event Event { get; set; }

        public FooterPartialViewModel FooterPartialViewModel { get; set; }
    }
}
