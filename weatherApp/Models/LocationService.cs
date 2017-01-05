using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace RejseplanenWeather.Models
{
    public class LocationService
    {
        public string locationString { get; set; }
        public object getLocation()
        {
            var url = string.Format("http://xmlopen.rejseplanen.dk/bin/rest.exe/location?input={0}&format=json",locationString);
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}