using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4800_940.Models
{
    public class Employees
    {
        public int employeesID { get; set; }

        [Display(Name ="First Name")]
        [Required(ErrorMessage ="Entry required - First name is required")]
        public string firstName { get; set; }

        [Display(Name ="Last Name")]
        [Required(ErrorMessage = "Entry required - First name is required")]
        public string lastName { get; set; }

        [Display(Name = "Phone")]
        [Required]
        [StringLength(12)]
        public string phone { get; set; }

        [Display(Name ="Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name ="Area of Specialty")]
        [Required]
        public string areaOfSpeciality { get; set; }

        [Display(Name ="Date of Employment")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Required]
        
        public DateTime dateOfEmployment { get; set; }

        [Display(Name = "Employee Name")]
        public string fullName {
            get
            {
                return lastName + ", " + firstName;
            }
        }
      
        public ICollection<Appointment> Appointment { get; set; }
    }
}