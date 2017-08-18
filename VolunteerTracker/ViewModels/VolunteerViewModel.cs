using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using VolunteerTracker.Models.Volunteer;

namespace VolunteerTracker.ViewModels
{
    public class VolunteerViewModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        // FIRST NAME
        [Required]
        [Display(Name = "First Name")]
        [StringLength(35)]
        public string FirstName { get; set; }

        // LAST NAME
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(35)]
        public string LastName { get; set; }

        // USERNAME
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        // PASSWORD
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }

        // AVAILABILITY
        [Display(Name = "Availability")]
        public DayAvailable DayAvailable { get; set; }

        // PREFERRED CENTER(S)
        [Display(Name = "Preferred Center")]
        public Center CenterPreferred { get; set; }

        // EDUCATION
        [Display(Name = "Education")]
        public EducationLevel EducationLevel { get; set; }

        // SKILLS
        [Display(Name = "Skill")]
        public Skill Skill { get; set; }

        // LICENSES
        [Display(Name = "License")]
        public License CurrentLicense { get; set; }

        // ADDRESS
        [Display(Name = "Address")]
        public AddressViewModel Address { get; set; }

        // PHONE
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        // EMAIL
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(255)]
        public string Email { get; set; }

        // EMERGENCY CONTACT
        [Display(Name = "Emergency Contact")]
        public ContactViewModel EmergencyContact { get; set; }

        // DRIVER'S LICENSE
        [Display(Name = "Driver's License")]
        public bool HasDriversLicense { get; set; }

        // SOCIAL SECURITY CARD
        [Display(Name = "Social Security Card")]
        public bool HasSsCard { get; set; }

        // STATUS
        [Display(Name = "Status")]
        public Status Status { get; set; }
    }
}