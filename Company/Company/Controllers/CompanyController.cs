using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using Company.Models;

namespace Company.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Home()
        {
            Company.Models.Company company = new Company.Models.Company();
            Company1 c = new Company1();
            c.Name = "Abc Globla";

            ViewBag.Name = "ABC Global";
            return View();
        }
        public ActionResult Projects()
        {
            string[] project = new string[3];
            project[0] = "School Management";
            project[1] = "Hospital Management";
            project[2] = "University Management";

            ViewBag.Project = project;
            return View();
        }
        public ActionResult Team() 
        {
            return View();
        }
    }
}