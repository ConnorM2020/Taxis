using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxisImporter.Models
{
    public class Taxis
    {
        [Ignore]
        public int Id { get; set; }

        [Name("pickup")] 
        public DateTime pickup { get; set; }

        [Name("dropoff")]
        public DateTime dropoff { get; set; }

        [Name("passengers")]
        public int passengers { get; set; }

        [Name("distance")]
        public decimal distance { get; set; }

        [Name("fare")]
        public decimal fare { get; set; }

        [Name("tip")]
        public decimal tip { get; set; }

        [Name("tolls")]
        public decimal toll { get; set; }

        [Name("total")]
        public double total { get; set; }

        [Name("color")]
        public string colour { get; set; }

        [Name("payment")]
        public string payment { get; set; }

        [Name("pickup_zone")]
        public string pickupZone { get; set; }

        [Name("dropoff_zone")]
        public string dropoffZone { get; set; }

        [Name("pickup_borough")]
        public string pickup_borough { get; set; }

        [Name("dropoff_borough")]
        public string? dropoff_borough { get; set; }
    }
}
