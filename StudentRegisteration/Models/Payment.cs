using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRegisteration.Models
{
    public class Payment
    {
        public int Id { get; set; }

        // For Su Yi to write 
        public string PaymentType { get; set; }
        public DateTime TransactionDateTime { get; set; }
    }
}