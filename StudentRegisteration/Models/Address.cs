using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRegisteration.Models
{
    public class Address
    {
        public int Id { get; set; }
        // For Su Yi to write 
        public string State { get; set; }
        public string City { get; set; }
        public string Township { get; set; }
    }
}