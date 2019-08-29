using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auto.Data.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string BrandModel { get; set; }

        public decimal Price { get; set; }

        public DateTime PublishedOn { get; set; }

        public string Hps { get; set; }

        public string Color { get; set; }

        public string Year { get; set; }

        public string Fuel { get; set; }

        public string Description { get; set; }

        public string PhotoUrl { get; set; }

        public int Doors { get; set; }

        public string GearBox { get; set; }

        public int Lenght { get; set; }

        public int CategoryId { get; set; }

        [NotMapped]
        public Category Category { get; set; }

        public string AutoUserId { get; set; }

        [NotMapped]
        public AutoUser AutoUser { get; set; }

        public string NameUser { get; set; }

        public int MilelageKM { get; set; }

        public string City { get; set; }
    }
}