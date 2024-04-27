using Core.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class ProductContactFormModel
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Company { get; set; }

        public string Position { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        [Display(Name = "What is the nature of your request?")]
        public NatureRequest NatureRequest { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
