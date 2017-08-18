using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VolunteerTracker.Models.Volunteer
{
    public class Status
    {
        [Key]
        public int Id { get; set; }

        public string Approved { get; set; }
        public string Pending { get; set; }
        public string Disapproved { get; set; }
        public string Inactive { get; set; }
    }
}