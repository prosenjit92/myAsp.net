using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture_2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult List()
        {
            ViewBag.Name = "Prosenjit";
            return View();
        }
    }
}