using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VolunteerTracker.Models.Volunteer
{
    public class CurrentLicense
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}