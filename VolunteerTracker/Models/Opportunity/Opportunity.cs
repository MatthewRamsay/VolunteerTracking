using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VolunteerTracker.Models.Volunteer;

namespace VolunteerTracker.Models.Opportunity
{
    public class Opportunity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Center Location { get; set; }
    }
}