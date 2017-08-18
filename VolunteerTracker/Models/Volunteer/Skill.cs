using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace VolunteerTracker.Models.Volunteer
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}