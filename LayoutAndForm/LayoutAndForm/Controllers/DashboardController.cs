using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutAndForm.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashbord
        public ActionResult Index()
        {
            return View();
        }
    }
}