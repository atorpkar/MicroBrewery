using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MicroBreweryWebApplication2.Models;
using MicroBreweryWebApplication2.Services;

namespace MicroBreweryWebApplication.Controllers
{
    public class BeerController : Controller
    {

        IBeerRepository repository = new BeerRepository();

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