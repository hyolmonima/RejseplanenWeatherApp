using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace weatherApp.Models
{

    public class origDest
    {
        public string baseUrl { get; set; }
        public object getTripInfo()
        {
            //string url = "http://xmlopen.rejseplanen.dk/bin/rest.exe/trip?originId=" + origin + "&destId=" + destination + "&format=json";
            var client = new WebClient();
            var content = client.DownloadString(baseUrl);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}