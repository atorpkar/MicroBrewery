using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroBreweryWebApplication.Controllers
{
    public class HomeController : Controller
    {

        // private BreweryServices breweryService; 

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

        public ActionResult User()
        {
            ViewBag.Message = "USER PAGE";

            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "ADMIN PAGE";

            return View();
        }
    }
}