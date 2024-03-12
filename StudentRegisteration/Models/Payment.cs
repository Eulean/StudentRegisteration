using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegisteration.Models
{
    public class Payment
    {
        public int Id { get; set; }

        // For Su Yi to write 
        [Required]
        public string PaymentType { get; set; }

        [Display(Name ="Transaction Date")]
        [DataType(DataType.DateTime)]
        public DateTime TransactionDateTime { get; set; }
    }
}