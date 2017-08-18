using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VolunteerTracker.Models.Volunteer;

namespace VolunteerTracker.ViewModels
{
    public class VolunteerViewModel
    {
        [Display(Name = "First Name")]
        [StringLength(35)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(35)]
        public string LastName { get; set; }

        [Display(Name = "Preferred Center(s)")]
        public IList<Center> CentersPreferred { get; set; }

        [Display(Name = "Availability")]
        public IList<DayAvailable> DaysAvailable { get; set; }

        [Display(Name = "Education")]
        public string HighestEducation { get; set; }

        [Display(Name = "Skills")]
        public IList<Skill> Skills { get; set; }

        [Display(Name = "Licenses")]
        public IList<CurrentLicense> Licenses { get; set; }

        // Status of volunteer (Approved, Pending, Disapproved, Inactive)
        [Display(Name = "Status")]
        public IList<Status> Statuses { get; set; }
    }
}