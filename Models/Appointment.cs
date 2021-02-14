using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4800_940.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }
        public DateTime dateOfAppointment { get; set; }
        public DateTime appointmentTime { get; set; }
        public string apptReason { get; set; }
        public int employeesID { get; set; }
        public virtual Employees Employees { get; set; }
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }
    }
}