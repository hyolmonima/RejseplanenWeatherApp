using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace RejseplanenWeather.Models
{
    public class WeatherByCoordinates
    {
        public decimal x { get; set; }

        public decimal y { get; set; }
        public object getWeatherForcast()
        {
            //string destination = "Roskilde";
            var  url = string.Format("http://api.openweathermap.org/data/2.5/weather?lon={0}&lat={1}&APPID=67747486e2d5351d2a8c6c0c70cf5df7&units=metric", x,y);
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}