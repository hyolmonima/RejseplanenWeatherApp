using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace RejseplanenWeather.Models
{
    public class Weather
    {
        public string destination { get; set; }
        public object getWeatherForcast()
        {
            //string destination = "Roskilde";
            var  url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&APPID=67747486e2d5351d2a8c6c0c70cf5df7&units=metric",destination);
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}