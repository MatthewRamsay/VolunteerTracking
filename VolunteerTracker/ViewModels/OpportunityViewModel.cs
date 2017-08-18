using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VolunteerTracker.Models.Volunteer;

namespace VolunteerTracker.ViewModels
{
    public class OpportunityViewModel
    {
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