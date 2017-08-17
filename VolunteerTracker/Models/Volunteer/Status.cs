using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunteerTracker.Models.Volunteer
{
    public class Status
    {
        public bool Approved { get; set; }
        public bool Pending { get; set; }
        public bool Disapproved { get; set; }
        public bool Inactive { get; set; }
    }
}