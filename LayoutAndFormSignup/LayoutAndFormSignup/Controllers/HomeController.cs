using LayoutAndFormSignup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutAndFormSignup.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About() 
        { 
            return View(); 
        }
        [HttpGet]
        public ActionResult Login() 
        { 
            return View(); 
        }
        [HttpPost]
        public ActionResult Login(Login l) 
        {
            
            return View(l);       
        }
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(SignUp s) 
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }

            return View(s); 
        }
        [HttpGet]
        public ActionResult Signup1()
        { 
            return View(); 
        }
        [HttpPost]
        public ActionResult Signup1(SignUp1 s)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            return View(s);
        }
    }
}