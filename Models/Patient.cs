using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4800_940.Models
{
    public class Patient
    {
        public int patientID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
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