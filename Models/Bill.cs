using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4800_940.Models
{
    public class Bill
    {
        public int billID { get; set; }

        [Display(Name = "Amount")]
        [Required]
        [Range(0.01, 100000000.00, ErrorMessage = "Amount must be in the range of $0.01 - $1,000,000.00")]
        [DisplayFormat(DataFormatString ="{0:c}", ApplyFormatInEditMode = true)]
        public decimal amount { get; set; }

        [Display(Name = "Status")]
        [Required]
        public string status { get; set; }
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }
    }
}