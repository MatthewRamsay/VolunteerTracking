using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunteerTracker.Models.Volunteer
{
    public class Address
    {
        public int Id { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}