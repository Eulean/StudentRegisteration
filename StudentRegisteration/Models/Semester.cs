using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegisteration.Models
{
    public class Semester
    {
        public int Id { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [Range(1,2)]
        public int SemesterNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Course { get; set; }

    }
}