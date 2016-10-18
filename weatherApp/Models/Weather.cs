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
        public object getWeatherForcast()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Cleveland&APPID=67747486e2d5351d2a8c6c0c70cf5df7";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}