using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealestateApplication.Models
{
    public class Ad
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string TypeOfAd { get; set; } // request or sell or rent
        public decimal Price { get; set; }
        public decimal Area { get; set; }
        public bool Furnished { get; set; }
        public int YearOfConstruction { get; set; }
        public string Heating { get; set; } = "";
        public string Description { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime CreateDate { get; set; }
        public string UserId { get; set; }
    }
}
