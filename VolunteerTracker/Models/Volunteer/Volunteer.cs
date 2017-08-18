
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Microsoft.Owin.BuilderProperties;

namespace VolunteerTracker.Models.Volunteer
{
    public class Volunteer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public IList<DayAvailable> DaysAvailable { get; set; }
        public IList<Center> CentersPreferred { get; set; }
        public string HighestEducation { get; set; }
        public IList<Skill> Skills { get; set; }
        public IList<CurrentLicense> Licenses { get; set; }
        public Address Address { get; set; }
        public IList<ContactNumber> ContactNumbers { get; set; }
        public string Email { get; set; }
        public IList<Contact> EmergencyContacts { get; set; }
        public bool HasDriversLicense { get; set; }
        public bool HasSsCard { get; set; }

        // Status of volunteer (Approved, Pending, Disapproved, Inactive)
        public IList<Status> Statuses { get; set; }
    }
}