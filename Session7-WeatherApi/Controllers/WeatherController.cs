using Session7_WeatherApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Session7_WeatherApi.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        public ActionResult Index()
        {
            //return View();
            return View(new WeatherViewModel());
        }

        // Send data requested: [HttpPost]
        [HttpPost]
        public ActionResult Index(string RequestedCity)
        {
            // assign API KEY from openweathermap
            string appId = "4d4257f81d5fb1ae4e9dcf1f73db071c";

            // API path with CITY parameter and api key parameter
            // units: standard(default)-Kelvin, metric-Celsius, imperial-Fahrenheit 
            // cnt: Number of cities around the point that should be returned, default 5, max 50.
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&cnt=1&APPID={1}", RequestedCity, appId);


            using (WebClient client = new WebClient())
            {
                // get json by URL
                string jsonResult = client.DownloadString(url);
                /*"QuickWatch" can display result: text visualizer:
                { "coord":{ "lon":-79.4163,"lat":43.7001},"weather":[{ "id":803,"main":"Clouds","description":"broken clouds","icon":"04d"}],"base":"stations","main":{ "temp":0.74,"feels_like":-5.01,"temp_min":0.56,"temp_max":1.11,"pressure":1020,"humidity":55},"visibility":10000,"wind":{ "speed":7.11,"deg":339,"gust":8.85},"clouds":{ "all":76},"dt":1617293438,"sys":{ "type":1,"id":718,"country":"CA","sunrise":1617274716,"sunset":1617320637},"timezone":-14400,"id":6167865,"name":"Toronto","cod":200}
                "json formatter" can convert text into json*/

                //  Convert jsonResult string to OBJECT weatherDto(Data Transfer Object)
                WeatherDto weatherDto = (new JavaScriptSerializer()).Deserialize<WeatherDto>(jsonResult);

                //weatherviewmodel design to send only required fields not all fields which received from api  
                WeatherViewModel rslt = new WeatherViewModel();
                rslt.RequestedCity = RequestedCity;
                rslt.Country = weatherDto.sys.country;
                rslt.City = weatherDto.name;
                rslt.Lat = Convert.ToString(weatherDto.coord.lat);
                rslt.Lon = Convert.ToString(weatherDto.coord.lon);
                rslt.Description = weatherDto.weather[0].description; //weather[0] -> Id
                rslt.Humidity = Convert.ToString(weatherDto.main.humidity);
                rslt.Temp = Convert.ToString(weatherDto.main.temp);
                rslt.TempFeels_like = Convert.ToString(weatherDto.main.feels_like);
                rslt.Temp_max = Convert.ToString(weatherDto.main.temp_max);
                rslt.Temp_min = Convert.ToString(weatherDto.main.temp_min);
                rslt.WeatherIcon = weatherDto.weather[0].icon;
                return View(rslt);


                // how to convert back from OBJECT to JSON string
                // ar jsonStr = new JavaScriptSerializer().Serialize(rslt);

               
            }

        }





    }
}
