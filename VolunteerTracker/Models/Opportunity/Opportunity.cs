using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VolunteerTracker.Models.Volunteer;

namespace VolunteerTracker.Models.Opportunity
{
    public class Opportunity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Centers Location { get; set; }
    }

    public enum Centers
    {
        FSCJ = 1,
        FSU,
        JU,
        SJRSC,
        UCF,
        UNF,
        UF
    }
}