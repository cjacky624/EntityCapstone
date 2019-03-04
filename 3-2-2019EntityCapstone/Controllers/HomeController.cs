using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_2_2019EntityCapstone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

// Admin can see list of all courses offered by GC
// Admin can see list of all students in any course
// Admin can perform CRUD operations on both courses and students in any course.
// Student can see list of all courses they took.
// Student can get past info on class such as final grade, semester, min, max & avg for all students enrolled in that class w/ the student.
// Student can search for classes to enroll in.
