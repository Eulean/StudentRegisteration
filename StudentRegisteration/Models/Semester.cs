using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRegisteration.Models
{
    public class Semester
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}