using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentRegisteration.Models
{
    public class Student
    {
        //student Info

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } 

        [Required]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MMM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        // extra contact info
        [StringLength(50)]
        public string Phone {  get; set; }

        [Required]
        public short NRC { get; set; }

        [Display(Name = "Registeration Date")]
        public DateTime RegDate { get; set; }

        //Gender
        [Required]
        public Gender Gender { get; set; }   
        public byte GenderId { get; set; }

        //Sememster
        [Required]
        public Semester Semester { get; set; }
        public int SemesterId { get; set; }

        //Address
        [Required]
        public Address Address { get; set; }
        public int AddressId { get; set; }

        //PayMent
        [Required]
        public Payment Payment { get; set; }
        public int PaymentId { get; set; }


        //Generated

        public string ApplicationId { get; set; }
    }
}