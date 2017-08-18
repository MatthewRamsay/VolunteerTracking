using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VolunteerTracker.Models.Volunteer;

namespace VolunteerTracker.ViewModels
{
    public class ContactViewModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

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