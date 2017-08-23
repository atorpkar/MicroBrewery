using MicroBreweryWebApplication2.Models;
using System.Data.Entity; // Entity Framework Dependency (Reference)

namespace MicroBreweryWebApplication2.Services
{
    public class MicroBreweryContext : DbContext
    {
        public DbSet<MicroBrewery> MicroBrewery { get; set; }
    }
}