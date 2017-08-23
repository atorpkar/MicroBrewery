using System.Collections.Generic;
using MicroBreweryWebApplication2.Models;


namespace MicroBreweryWebApplication2.Services
{
    public interface IMicroBreweryRepository
    {
        IEnumerable<MicroBrewery> GetAll();

        bool Add(MicroBrewery brewery);
    }
}
