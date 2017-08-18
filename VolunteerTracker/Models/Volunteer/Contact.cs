using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VolunteerTracker.Models.Volunteer
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
        public Address Address { get; set; }
        public IList<ContactNumber> ContactNumbers { get; set; }
    }
}