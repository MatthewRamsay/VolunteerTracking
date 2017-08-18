using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VolunteerTracker.Models.Volunteer;

namespace VolunteerTracker.ViewModels
{
    public class ContactViewModel
    {
        // NAME
        [Required]
        [Display(Name = "Name")]
        public string FullName { get; set; }

        // ADDRESS
        [Display(Name = "Address")]
        public Address Address { get; set; }

        // PHONE
        [Display(Name = "Phone")]
        public IList<ContactNumber> ContactNumbers { get; set; }
    }
}