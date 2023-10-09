using AbcCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Web;
using System.Web.Mvc;

namespace AbcCompany.Controllers
{
    public class CompanyController : Controller
    {

        // GET: Company
        public ActionResult Home()
        {
            /*Company c = new Company();
            c.Name = "ABC Global";
            c.Address = "Kuril";
            c.Email = "abcglobal@gmail.com";
            c.Desc = "IT company";*/

            Company c = new Company()
            {
                Name = "ABC Global",
                Address = "Kuril Biswaroad",
                Email = "abcglobal@gmail.com",
                Desc = "IT Company"
            };

            return View(c);
        }
        public ActionResult Projects() 
        {
            var p1 = new Project()
            {
                Titel = "School Management",
                Client = "Korim"
            };
            var p2 = new Project()
            {
                Titel = "Hospital Management",
                Client = "Rahim"
            };
            var projects = new Project[] { p1, p2 };

            return View(projects);
        }
        public ActionResult Team()
        {
            var names = new string[] { "Rahim", "Karim", "Jalal", "Sajib" };


            return View(names);
        }
    }
}