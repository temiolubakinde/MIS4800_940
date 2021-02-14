using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4800_940.Models
{
    public class Payment
    {
        public int paymentID { get; set; }
        public decimal amount { get; set; }
        public DateTime date { get; set; }
        public string method { get; set; }
        public string insurance { get; set; }
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }

    }
}