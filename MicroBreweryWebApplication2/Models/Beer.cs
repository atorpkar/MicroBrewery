using System.ComponentModel.DataAnnotations;

namespace MicroBreweryWebApplication2.Models
{
    public class Beer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        // public BeerType Type { get; set; }

        public string Description { get; set; }

        [Range(0,20)]
        public double AlcoholPercentage { get; set; }

        [Range(0, 1)]
        public double Volume { get; set; }
        
        public decimal Price { get; set; }

        // public MicroBrewery MadeBy { get; set; }

    }
}