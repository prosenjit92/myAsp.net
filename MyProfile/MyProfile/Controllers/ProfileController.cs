using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProfile.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Home()
        {
            ViewBag.Name = "Prosenjit Biswas";
            ViewBag.Id = "19-39637-1";
            ViewBag.Email = "pb117702@gmail.com";
            ViewBag.ContNo = 01792000004;
            return View();
        }
        public ActionResult Education() 
        {
            
            return View();
        }
        public ActionResult Projects()
        {

            return View();
        }
        public ActionResult References() 
        {
            ViewBag.R1 = "Tanvir Ahmed";
            ViewBag.R2 = "Abhijit Bhowmik";

            return View();
        }
    }
}