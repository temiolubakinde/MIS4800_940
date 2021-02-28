using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4800_940.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }

        [Display(Name ="Date of Appointment")]
        [Required]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode =true)]
        [DataType(DataType.Date)]
        
        public DateTime dateOfAppointment { get; set; }

        [Display(Name = "Appointment Time")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime appointmentTime { get; set; }

        [Display(Name = "Appointment Reason")]
        [Required]
        public string apptReason { get; set; }
        public int employeesID { get; set; }
        public virtual Employees Employees { get; set; }
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }
    }
}