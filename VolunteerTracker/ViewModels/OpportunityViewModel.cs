﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VolunteerTracker.Models.Volunteer;

namespace VolunteerTracker.ViewModels
{
    public class OpportunityViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        // NAME
        [Required]
        [Display(Name = "Opportunity")]
        public string Name { get; set; }

        // DATE
        [Required]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        // LOCATION
        [Required]
        [Display(Name = "Location")]
        public Center Location { get; set; }
    }
}