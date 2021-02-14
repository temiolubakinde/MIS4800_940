using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4800_940.Models
{
    public class Employees
    {
        public int employeesID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string areaOfSpeciality { get; set; }
        public DateTime dateOfEmployment { get; set; }
        public string fullName {
            get
            {
                return lastName + ", " + firstName;
            }
        }
      
        public ICollection<Appointment> Appointment { get; set; }
    }
}