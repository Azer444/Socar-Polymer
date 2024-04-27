using Core.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Models
{
    public class ProductContactMessage
    {
        public int Id { get; set; }

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

        [Display(Name = "Nature Request")]
        public NatureRequest NatureRequest { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
