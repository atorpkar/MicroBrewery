using System.ComponentModel.DataAnnotations;

namespace MicroBreweryWebApplication2.Models
{
    public class MicroBrewery
    {
        [Key]
        public int ID { get; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string OpeningHours { get; set; }

        public string Location { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

    }
}