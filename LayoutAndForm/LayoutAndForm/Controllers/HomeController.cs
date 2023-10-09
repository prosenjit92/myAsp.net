using LayoutAndForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutAndForm.Controllers
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
        /*//public ActionResult Login(FormCollection fc)
         //public ActionResult Login(string name, int id)
         {
             //From Request
             *//* ViewBag.name = Request["name"];
              ViewBag.id = Request["id"];
              ViewBag.gender = Request["gender"];
              ViewBag.profession = Request["profession"];*/

        /*ViewBag.name = fc["name"];
        ViewBag.id = fc["id"];
        ViewBag.gender = fc["gender"];
        ViewBag.profession = fc["profession"];*//*

        //ViewBag.name = name;
        //ViewBag.id = id;
        //ViewBag.gender = gender;
        //ViewBag.profession = profession;



        return View();
    }*/
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
        public ActionResult LoginSubmit() 
        {
            // validation
            //authentication
            TempData["msg"] = "Login Successfull";
            //return Redirect("https://www.aiub.edu/");
            return RedirectToAction("Index","Dashboard");
            
        }
    }
}