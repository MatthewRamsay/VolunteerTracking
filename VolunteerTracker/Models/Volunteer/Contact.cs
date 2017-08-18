using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VolunteerTracker.ViewModels;

namespace VolunteerTracker.Models.Volunteer
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
        public AddressViewModel Address { get; set; }
        public string Phone { get; set; }
    }
}