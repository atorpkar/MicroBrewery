using MicroBreweryWebApplication2.Models;
using System.Data.Entity; // Entity Framework Dependency (Reference)



namespace MicroBreweryWebApplication2.Services
{
    public class BeerContext : DbContext
    {
        public DbSet<Beer> Beers { get; set; }       
    }
}