using MicroBreweryWebApplication2.Models;
using System.Collections.Generic;

namespace MicroBreweryWebApplication2.Services
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> GetAll();

        bool Add(Beer beer);
    }
}