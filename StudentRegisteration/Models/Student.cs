using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegisteration.Models
{
    public class Student
    {
        //student Info
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }

        // extra contact info
        public string Phone {  get; set; }   
        public short NRC { get; set; }
        public DateTime RegDate { get; set; }

        //Gender
        public Gender Gender { get; set; }   
        public int GenderId { get; set; }

        //Sememster
        public Semester Semester { get; set; }
        public int SemesterId { get; set; }
          
        //Address
        public Address Address { get; set; }
        public int AddressId { get; set; }
        
        //PayMent
        public Payment Payment { get; set; }
        public int PaymentId { get; set; }
    }
}