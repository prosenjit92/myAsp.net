using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApplication1.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult List()
        {
            int a = 48;
            int b = 89;
            int c = a + b ;

            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.C = c;

            string[] names = new string[3];
            names[0] = "Prosenjit";
            names[1] = "Utsho";
            names[2] = "Biswas";

            ViewBag.Names = names;
            ViewData["A"] = a;
            return View();
        }
        public ActionResult Create() 
        {
            return View();
        }
    }
}