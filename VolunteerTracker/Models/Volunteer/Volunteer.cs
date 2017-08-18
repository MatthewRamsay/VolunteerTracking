
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
        public int VolunteerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Center CenterPreferred { get; set; }
        public Skills Skill { get; set; }
        public DaysAvailable AvailableDay { get; set; }
        public string Address { get; set; }
        public int HomeNumber { get; set; }
        public int CellNumber { get; set; }
        public int WorkNumber { get; set; }
        public string Email { get; set; }
        public string HighestEducation { get; set; }
        public Licenses CurrentLicense { get; set; }
        public string EmergencyContact { get; set; }
        public bool HasDriversLicense { get; set; }
        public bool HasSsCard { get; set; }
        public Statuses Status { get; set; }
    }

    public enum Statuses
    {
        Approved=1, 
        Pending, 
        Disapproved,
        Inactive
    }

    public enum Center
    {
        FSCJ=1,
        FSU,
        JU,
        Stanford,
        UCF,
        UF,
        UNF
    }

    public enum Skills
    {
        Running=1,
        Jumping,
        Swimming, 
        Teaching,
    }

    public enum DaysAvailable
    {
        Monday=1,
        Tuesday,
        Wednsday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    
    public enum Licenses
    {
        ChildCare=1,
        ElderCare,
        Medical
    }
}
