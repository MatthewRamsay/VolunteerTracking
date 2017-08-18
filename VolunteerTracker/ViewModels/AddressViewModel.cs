﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VolunteerTracker.ViewModels
{
    public class AddressViewModel
    {
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
        [MaxLength(2)]
        public string State { get; set; }

        // ZIP CODE
        [Required]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
    }
}