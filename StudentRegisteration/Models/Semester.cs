using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegisteration.Models
{
    public class Semester
    {
        public byte Id { get; set; }
        public int Year { get; set; }
        public int SemesterNumber { get; set; }
        public string Course { get; set; }

    }
}