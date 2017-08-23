using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery
{
    public class MicroBrewery
    {
        private static int breweryCounter = 0;
        public HashSet<Beer> beers;

        public int ID { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OpeningHours { get; set; }
        public string Location { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public MicroBrewery(string name, string description, string openingHours, string location, double latitude = 0.0, double longitude = 0.0)
        {
            this.ID = breweryCounter;
            breweryCounter++;
            this.Name = name;
            this.Description = description;
            this.OpeningHours = openingHours;
            this.Location = location;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.beers = new HashSet<Beer>();
        }

        public MicroBrewery(string name, string description, string openingHours, string location, double latitude, double longitude, HashSet<Beer> beers) : this(name, description, openingHours, location, latitude, longitude)
        {
            this.beers = beers;  
        }

        public void PrintBreweryInformation()
        {
            Console.WriteLine($"Brewery: {Name} \nOpening Hours: {OpeningHours} \nLocation: {Location} ({Latitude}, {Longitude})");
            Console.WriteLine($"Description: {Description}");
        }

        public void PrintBeersInBrewery()
        {
            Console.Write($"Brewery {Name} has the following selection of beers: ");
            foreach (var beer in beers)
            {
                Console.Write(beer.Name );
            }
        }

        public bool AddBeerToBrewery(Beer beer)
        {
            return beers.Add(beer);
        }

    }

    





}
