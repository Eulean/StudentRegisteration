using StudentRegisteration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRegisteration.ViewModels
{
    public class RegistrationViewModel
    {
        public int Step { get; set; }
        public Student Student { get; set; }
        public Address Address { get; set; }
        public Semester Semester { get; set; }
        public Payment Payment { get; set; }
    }
}