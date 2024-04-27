using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }

        public string Country { get; set; }

        public string Company { get; set; }

        public string Position { get; set; }
    }
}
