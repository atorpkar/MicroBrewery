using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MicroBreweryWebApplication2.Models;


namespace MicroBreweryWebApplication2.Services
{
    public class MicroBreweryRepository : IMicroBreweryRepository
    {
        MicroBreweryContext microBreweryContext = new MicroBreweryContext();

        public IEnumerable<MicroBrewery> GetAll()
        {
            return microBreweryContext.MicroBrewery.ToList();
        }

        public bool Add(MicroBrewery brewery)
        {
            microBreweryContext.MicroBrewery.Add(brewery);
            return microBreweryContext.SaveChanges() == 1;
        }
    }
}