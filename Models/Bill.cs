using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4800_940.Models
{
    public class Bill
    {
        public int billID { get; set; }
        public decimal amount { get; set; }
        public string status { get; set; }
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }
    }
}