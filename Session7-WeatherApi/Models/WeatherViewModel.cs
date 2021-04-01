using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Session7_WeatherApi.Models
{

    // WeatherViewModel class to show selected information in the view
    public class WeatherViewModel
    {
        [Display (Name = "City")]
        public string RequestedCity { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        [Display(Name = "Latitude")]
        public string Lat { get; set; }

        [Display(Name = "Longitude")]
        public string Lon { get; set; }

        public string Description { get; set; }

        public string Humidity { get; set; }

        [Display(Name = "Temperature")]
        public string Temp { get; set; }

        [Display(Name = "Feels Like")]
        public string TempFeels_like { get; set; }

        [Display(Name = "Temperature Max")]
        public string Temp_max { get; set; }

        [Display(Name = "Temperature Min")]
        public string Temp_min { get; set; }

        public string WeatherIcon { get; set; }

    }

     
}