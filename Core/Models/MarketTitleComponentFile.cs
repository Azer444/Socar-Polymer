using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class MarketTitleComponentFile
    {
        public int Id { get; set; }

        [Required]
        public string DisplayName { get; set; }

        [Required]
        public string FileName { get; set; }

        public MarketTitleComponent MarketTitleComponent { get; set; }

        public int MarketTitleComponentId { get; set; }
    }
}
