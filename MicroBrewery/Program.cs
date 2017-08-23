using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brewery;

namespace BreweryApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            // Beer[] beers = { b1, b2, b3 };

            HashSet<Beer> beers = new HashSet<Beer>();

            // Create beers 
            Beer b1 = new Beer("Best beer", BeerType.Blonde, "Best blonde beer", 5.5, 0.33, 89);
            Beer b2 = new Beer("Rignes Pilsner", BeerType.Pilsner, "Crap norwegian beer", 4.7, 0.6, 79);
            Beer b3 = new Beer("Coffee Stout", BeerType.Stout, "Dark and creamy", 8.5, 0.4, 99);

            beers.Add(b1);
            beers.Add(b2);
            beers.Add(b3);

            // Create micro breweries
            MicroBrewery mb1 = new MicroBrewery("Andreas Mikrobryggeri", "Best brewery in town", "06:00 - 04:00", "Sandefjord", 59.128772, 10.223687);
            MicroBrewery mb2 = new MicroBrewery("Micro Drewelery", "No description", "15:00 - 23:00", "Sagene, Oslo", 0.0, 0.0, beers);
            MicroBrewery mb3 = new MicroBrewery("Trondheim Mikrobryggeri", "No description", "16:00 - 02:00", "Trondheim", 63.429955, 10.389635);

            //HashSet<Microbrewery> microbreweries = new HashSet<Microbrewery>();
            //microbreweries.Add(mb1);
            //microbreweries.Add(mb2);
            //microbreweries.Add(mb3);

            MicroBrewery[] microbreweries = { mb1, mb2, mb3 };

            int menuChoice;
            menuChoice = PrintMenuAndAskForChoice();

            switch (menuChoice)
            {
                case 1:
                    PrintAllBreweries(microbreweries);
                    break;

                case 2:
                    PrintAllBeers(beers);
                    break;

                case 3:
                    Console.WriteLine("Registering a new Micro-Brewery");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string description = Console.ReadLine();
                    Console.Write("Opening hours: ");
                    string openingHours = Console.ReadLine();
                    Console.Write("Location: ");
                    string location = Console.ReadLine();

                    //microbreweries.a

                    break;

                case 4:

                case 5:

                case 6:

                case 7:

                case 8:

                default:
                    break;
            }


            // Print information
            mb1.PrintBreweryInformation();
            Console.WriteLine();

            mb2.PrintBreweryInformation();
            Console.WriteLine();

            b1.Print();

            mb1.AddBeerToBrewery(b1);
            Console.WriteLine();
            mb1.PrintBeersInBrewery();

            Console.WriteLine();
            mb2.PrintBeersInBrewery();

            // Search for micro brewery

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Input name of the Micro Brewery you want to search for: ");
            string microBrewerySearchString = Console.ReadLine();

            // Make regular expression to search for lowercase, uppcase, partly fulfilled string, etc. 

            foreach (var brewery in microbreweries)
            {
                if (brewery.Name == microBrewerySearchString)
                {
                    Console.WriteLine("Search successful. Printing brewery information...\n");
                    brewery.PrintBreweryInformation();
                }
            }

            // Add ratings
            Rating r1 = new Rating(1, 1, 5);
            Rating r2 = new Rating(1, 1, 4);
            Rating r3 = new Rating(1, 1, 3);
            Rating r4 = new Rating(1, 1, 4);
            Rating r5 = new Rating(1, 1, 4);
            Rating r6 = new Rating(1, 1, 2);

            HashSet<Rating> ratings = new HashSet<Rating>();
            ratings.Add(r1);
            ratings.Add(r2);
            ratings.Add(r3);
            ratings.Add(r4);
            ratings.Add(r5);
            ratings.Add(r6);



            Console.ReadLine();

        }

        private static void PrintAllBeers(HashSet<Beer> beers)
        {
            Console.WriteLine($"Registered beers in the system are: ");
            foreach (var beer in beers)
            {
                Console.WriteLine($"-{beer.Name}");
            }
        }

        private static void PrintAllBreweries(MicroBrewery[] microbreweries)
        {
            Console.WriteLine("Registered Micro-Breweries in the system are:");
            foreach (var microbrewery in microbreweries)
            {
                Console.WriteLine($"- {microbrewery.Name}");
            }
        }

        private static int PrintMenuAndAskForChoice()
        {
            int menuChoice;
            Console.WriteLine("Menu: \n");

            Console.WriteLine("1. Print list of all Micro Breweries");
            Console.WriteLine("2. Print list of all registered beers");
            Console.WriteLine("3. Search for a Micro Brewery");
            Console.WriteLine("4. Search for beers with a minimum rating");
            Console.WriteLine("5. Register a new Micro Brewery");
            Console.WriteLine("6. Register a new beer");
            Console.WriteLine("7. Add a beer to a Micro Brewery");
            Console.WriteLine();
            Console.Write("Please input your menu choice ");

            do
            {
                Int32.TryParse(Console.ReadLine(), out menuChoice);
            } while (menuChoice < 1 && menuChoice > 9);
            return menuChoice;
        }
    }
}
