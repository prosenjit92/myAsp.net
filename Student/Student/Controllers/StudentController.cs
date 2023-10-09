using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Students.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult List()
        {
         
            ViewBag.Name = "Prosenjit Biswas";

            string[] names = new string[3];
            names[0] = "Taposh";
            names[1] = "Utsho";
            names[2] = "Tanim";
           
            ViewBag.Names = names;

           
            return View();
        }
    }
}