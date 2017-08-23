using System;
using System.Collections.Generic;
using MicroBreweryWebApplication2.Models;
using System.Linq;

namespace MicroBreweryWebApplication2.Services
{
    public class BeerRepository : IBeerRepository
    {
        BeerContext beerContext = new BeerContext();

        public IEnumerable<Beer> GetAll()
        {
            return beerContext.Beers.ToList();
        }

        public bool Add(Beer beer)
        {
            beerContext.Beers.Add(beer);
            return beerContext.SaveChanges() == 1;
        }


    }
}