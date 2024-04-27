﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class MarketComponentFile
    {
        public int Id { get; set; }

        [Required]
        public string DisplayName { get; set; }

        [Required]
        public string FileName { get; set; }

        public MarketComponent MarketComponent { get; set; }

        public int MarketComponentId { get; set; }
    }
}
