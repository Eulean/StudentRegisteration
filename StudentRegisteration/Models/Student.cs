using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegisteration.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Phone Number")]
        public string Phone {  get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "NRC Number")]
        public string NRC { get; set; }

        [Required]
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}