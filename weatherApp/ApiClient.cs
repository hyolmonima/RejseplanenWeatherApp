using RejseplanenWeather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace weatherApp
{
    public class ApiClient
    {
        private const string baseUrl = "http://xmlopen.rejseplanen.dk/bin/rest.exe/trip?originId={0}&destId={1}&format=json";

        public static void GetTrip(string originID, string destinationID)
        {
            var url = string.Format(baseUrl, originID, destinationID);

            var client = new WebClient();
            var content = client.DownloadString(url);

            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);

        }
        
    }
}