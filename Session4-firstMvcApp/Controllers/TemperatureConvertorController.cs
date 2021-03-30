using Session4_firstMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session4_firstMvcApp.Controllers
{
    public class TemperatureConvertorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TemperatureConvertor tc)
        {
            double tempInput = tc.Temperature;
            double result = 0;
            string symbol = "";

            if (tc.FromUnit == tc.ToUnit)
            {
                result = tempInput;
            }

            if (tc.FromUnit == TemperatureUnit.Celsius)
            {
                if (tc.ToUnit == TemperatureUnit.Fahrenheit)
                {
                    result = tempInput * 9 / 5 + 32;
                }
                if (tc.ToUnit == TemperatureUnit.Kelvin)
                {
                    result = tempInput + 273.15;
                }
            }

            if (tc.FromUnit == TemperatureUnit.Fahrenheit)
            {
                if (tc.ToUnit == TemperatureUnit.Celsius)
                {
                    result = (tempInput - 32) * 5 / 9;
                }
                if (tc.ToUnit == TemperatureUnit.Kelvin)
                {
                    result = (tempInput - 32) * 5 / 9 + 273.15;
                }
            }

            if (tc.FromUnit == TemperatureUnit.Kelvin)
            {
                if (tc.ToUnit == TemperatureUnit.Celsius)
                {
                    result = tempInput - 273.15;
                }
                if (tc.ToUnit == TemperatureUnit.Fahrenheit)
                {
                    result = (tempInput - 273.15) * 9 / 5 + 32;
                }
            }

            if (tc.ToUnit == TemperatureUnit.Celsius)
            {
                symbol = "°C";
            } else if (tc.ToUnit == TemperatureUnit.Fahrenheit)
            {
                symbol = "°F";
            } else
            {
                symbol = "K";
            }

            tc.ResultSymbol = symbol;
            tc.Result = result;

            return View(tc);
        }

    }
}