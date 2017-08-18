using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunteerTracker.Models.Volunteer
{
    public class Center
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Address Address { get; set; }
        public Contact PrimaryContact { get; set; }
    }
}