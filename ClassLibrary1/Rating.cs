using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery
{
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
}
