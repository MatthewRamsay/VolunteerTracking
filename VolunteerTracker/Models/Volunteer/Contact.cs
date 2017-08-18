using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunteerTracker.Models.Volunteer
{
    public class Contact
    {
        public string FullName { get; set; }
        public Address Address { get; set; }
        public IList<ContactNumber> ContactNumbers { get; set; }
    }
}