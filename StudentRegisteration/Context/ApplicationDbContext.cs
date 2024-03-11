using StudentRegisteration.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentRegisteration.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> students {  get; set; }
        public DbSet<Gender> genders { get; set; }
        public DbSet<Semester> semesters { get; set; }

        // Address and Payment is For Su Yi
    }
}