using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery
{
    public class Microbrewery
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

        public Microbrewery(string name, string description, string openingHours, string location, double latitude = 0.0, double longitude = 0.0)
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

        public Microbrewery(string name, string description, string openingHours, string location, double latitude, double longitude, HashSet<Beer> beers) : this(name, description, openingHours, location, latitude, longitude)
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

    public class Beer
    {
        private static int beerCounter = 0;

        public int ID { get; }
        public string Name { get; set; }
        public BeerType Type { get; set; }
        public string Description { get; set; }
        public double AlcoholPercentage { get; set; }
        public double Volume { get; set; }
        public decimal Price { get; set; }
        public Microbrewery MadeBy { get; set; }

        public Beer(string name, BeerType type, string description, double alcoholPercentage, double volume, decimal price)
        {
            this.ID = beerCounter;
            beerCounter++;
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.AlcoholPercentage = alcoholPercentage;
            this.Volume = volume;
            this.Price = price;
        }

        public void Print()
        {
            Console.WriteLine($"Beer: {Name} \nType: {Type} \nAlcohol Percentage: {AlcoholPercentage} \nVolume: {Volume} \nPrice: {Price}");
            Console.WriteLine($"Description: {Description}");
        }

    }

    public class Rating
    {
        private static int ratingCounter = 0;

        public int ID { get; set; }
        public int BeerID { get; set; }
        public int MicroBreweryID { get; set; }
        public int RatingScore { get; set; }

        public Rating() { }
        public Rating(int beerID, int microBreweryID, int ratingScore)
        {
            this.ID = ratingCounter;
            ratingCounter++;
            this.BeerID = beerID;
            this.MicroBreweryID = microBreweryID;
            this.RatingScore = ratingScore;
        }

        public void AddRating(int beerID, int microBreweryID, int ratingScore)
        {
            ID = ratingCounter;
            ratingCounter++;
            MicroBreweryID = microBreweryID;
            RatingScore = ratingScore;

            // check rating 0-10, throw exception if outside
            // bool return value if rating is successfully added

        }

        public void Print()
        {
            // to implement 
        }

        public double GetAverageRating(int beerID)
        {
            // to implement
            return 0;
        }


    }

    public enum BeerType
    {
        Pilsner,
        IPA,
        Pale_Ale,
        Wheat,
        Stout,
        Brown_Ale,
        Porter,
        Amber,
        Blonde,
        Undefined = -1
    }



}
