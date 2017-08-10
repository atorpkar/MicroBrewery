using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery
{
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
