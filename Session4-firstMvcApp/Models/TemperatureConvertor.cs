using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session4_firstMvcApp.Models
{
    public class TemperatureConvertor
    {
        public TemperatureUnit FromUnit { get; set; }
        public TemperatureUnit ToUnit { get; set; }
        public string ResultSymbol { get; set; }

        public double Temperature { get; set; }

        public double? Result { get; set; }
    }
}