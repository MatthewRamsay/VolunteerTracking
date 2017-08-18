using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VolunteerTracker.Models.Volunteer
{
    public class ContactNumber
    {
        [Key]
        public int Id { get; set; }

        public int HomeNumber { get; set; }
        public int WorkNumber { get; set; }
        public int CellNumber { get; set; }
    }
}