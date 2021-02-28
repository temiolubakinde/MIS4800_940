using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4800_940.Models
{
    public class Payment
    {
        public int paymentID { get; set; }
        [Display(Name = "Amount")]
        [Required]
        [Range(0.1, 10000000.00, ErrorMessage = "Amount must be in the range of $0.01 - $1,000,000.00")]
        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true)]
        public decimal amount { get; set; }
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Required]
       
        public DateTime? date { get; set; }

        [Display(Name = "Method")]
        public string method { get; set; }

        [Display(Name = "Insurance")]
        public string insurance { get; set; }
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }

    }
}