using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MicroBreweryWebApplication2.Models;
using MicroBreweryWebApplication2.Services;

namespace MicroBreweryWebApplication.Controllers
{
    public class HomeController : Controller
    {

        IBeerRepository repository = new BeerRepository();

        // GET: beer

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

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {

            return View();
        }

        public ActionResult Search()
        {

            return View(repository.GetAll());
        }

        [HttpPost]
        public ActionResult Add(Beer beer)
        {
            bool result = repository.Add(beer);
            //SaveResult saveResult = new SaveResult
            //{
            //    Succeeded = result,
            //    Message = result ? "Succeeded" : "Failed"
            //};
            return View("Admin");
        }
    }
}