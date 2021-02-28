using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4800_940.Models
{
    public class Patient
    {
        public int patientID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Entry required - First name is required")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Entry required - First name is required")]
        public string lastName { get; set; }

        [Display(Name = "Phone")]
        [Required]
        [StringLength(12)]
        
        public string phone { get; set; }

        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "City")]
        public string city { get; set; }

        [Display(Name = "Zip")]
        [Required]
        [StringLength(5)]
        public string zip { get; set; }

        [Display(Name = "Patient Name")]
        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }
       
        public  ICollection<Payment> Payment { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<Bill> Bill { get; set; }
    }
}