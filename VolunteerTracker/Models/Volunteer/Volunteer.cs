
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Owin.BuilderProperties;
using VolunteerTracker.ViewModels;

namespace VolunteerTracker.Models.Volunteer
{
    public class Volunteer
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DayAvailable DayAvailable { get; set; }
        public Center CenterPreferred { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public Skill Skill { get; set; }
        public License CurrentLicense { get; set; }
        public AddressViewModel Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ContactViewModel EmergencyContact { get; set; }
        public bool HasDriversLicense { get; set; }
        public bool HasSsCard { get; set; }
        public Status Status { get; set; }
    }

    public enum DayAvailable
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Center
    {
        [Display(Name = "Florida State College at Jacksonville")] FSCJ=1,
        [Display(Name = "Florida State University")] FSU,
        [Display(Name = "Jacksonville University")] JU,
        [Display(Name = "St. Johns River State College")] SJRSC,
        [Display(Name = "University of Central Florida")] UCF,
        [Display(Name = "University of North Florida")] UNF,
        [Display(Name = "University of Florida")] UF
    }

    public enum EducationLevel
    {
        [Display(Name = "High school")] Highschool=1,
        [Display(Name = "Some college")] College,
        [Display(Name = "Associate's degree")] Associates,
        [Display(Name = "Bachelor's degree")] Bachelors,
        [Display(Name = "Master's degree")] Masters,
        [Display(Name = "Doctorate or professional degree")] Doctorate
    }

    public enum Skill
    {
        Teaching=1,
        Swimming
    }

    public enum License
    {
        License1=1,
        License2,
        License3,
        License4,
        License5
    }

    public enum Status
    {
        Approved=1,
        Pending,
        Disapproved,
        Inactive
    }
}