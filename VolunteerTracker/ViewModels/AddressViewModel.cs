using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VolunteerTracker.Models.Volunteer;

namespace VolunteerTracker.ViewModels
{
    public class AddressViewModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        // STREET
        [Required]
        [Display(Name = "Street")]
        public string Street { get; set; }

        // CITY
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        // STATE
        [Required]
        [Display(Name = "State")]
        public States State { get; set; }

        // ZIP CODE
        [Required]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
    }
}