using StudentRegisteration.Context;
using StudentRegisteration.Models;
using StudentRegisteration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRegisteration.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext _context;

        public StudentController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            var viewModel = new RegistrationViewModel
            {
                Step = 1,
                Student = new Student(),
                Address = new Address(),
                Semester = new Semester(),
                Payment = new Payment()
            };

            return View(viewModel);

        }

        [HttpPost]
        public ActionResult Register(RegistrationViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                return View("_Step" + viewModel.Step, viewModel);
               
            }


            switch(viewModel.Step)
            {
                case 1:

                    var studentStep1 = new Student
                    {
                        Name = viewModel.Student.Name,
                        Email = viewModel.Student.Email,
                        Password = viewModel.Student.Password,
                        BirthDate = viewModel.Student.BirthDate,
                        Phone = viewModel.Student.Phone,
                        NRC = viewModel.Student.NRC,
                        RegDate = DateTime.Now,
                        GenderId = viewModel.Student.GenderId,
                    };

                    viewModel.Student = studentStep1;

                    viewModel.Step = 2;

                    return View("_Step2",viewModel);

                case 2:

                    var address = new Address
                    {
                        State = viewModel.Address.State,
                        City = viewModel.Address.City,
                        Township = viewModel.Address.Township,
                    };

                    viewModel.Student.Address = address;

                    viewModel.Student.Semester = viewModel.Semester;
                    viewModel.Student.Payment = viewModel.Payment;


                    viewModel.Step = 3;
                    return View("_Step3", viewModel);

                case 3:

                    // Generating the Application Id 
                    string applicationId = Guid.NewGuid().ToString();
                    var student = viewModel.Student;
                    student.ApplicationId = applicationId;


                    // Saving the data into database
                    _context.students.Add(student);
                    _context.SaveChanges();

                    /*return View("_Step3", viewModel);*/
                    return RedirectToAction("Success");

                default:

                    return RedirectToAction("Register");
            } 

            /*return View(viewModel);*/
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult History()
        {
            var students = _context.students.ToList();
            return View(students);
        }
    }
}