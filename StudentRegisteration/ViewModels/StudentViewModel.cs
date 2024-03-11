using StudentRegisteration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRegisteration.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Gender> Genders { get; set; }
        public IEnumerable<Semester> Semesters { get; set; }
    }
}