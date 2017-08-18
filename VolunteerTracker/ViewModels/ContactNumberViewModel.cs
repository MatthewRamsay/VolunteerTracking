using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VolunteerTracker.ViewModels
{
    public class ContactNumberViewModel
    {
        [Key]
        public int Id { get; set; }

        // HOME
        [Display(Name = "Home")]
        [DataType(DataType.PhoneNumber)]
        public int HomeNumber { get; set; }

        // WORK
        [Display(Name = "Work")]
        [DataType(DataType.PhoneNumber)]
        public int WorkNumber { get; set; }

        // CELL
        [Display(Name = "Cell")]
        [DataType(DataType.PhoneNumber)]
        public int CellNumber { get; set; }
    }
}