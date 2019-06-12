using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealestateApplication.Models.PropertyType
{
    public class Home
    { 
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public bool SellOrRent { get; set; } // True = sell, False= rent
        public decimal Price { get; set; }
        public decimal Area { get; set; }
        public bool Furnished { get; set; }
        public int YearOfConstruction { get; set; }
        public int NumberOfLevels { get; set; }
        public string Heating { get; set; } = "";
        public string Description { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime CreateDate { get; set; }
    }
}
