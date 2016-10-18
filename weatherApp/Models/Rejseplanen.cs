using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace RejseplanenWeather.Models
{
    public class Rejseplanen
    {
        public object getTripInfo()
        {
            string origin = "000000775";//Convert.ToString(origin);
            string destination = "008600646";// Convert.ToString(destination);
            //string url = "http://xmlopen.rejseplanen.dk/bin/rest.exe/trip?originId=" + origin + "&destId=" + destination + "&format=json";
            string url = "http://xmlopen.rejseplanen.dk/bin/rest.exe/trip?originId=" + origin + "&destId=" + destination + "&format=json";

            //string url = "http://xmlopen.rejseplanen.dk/bin/rest.exe/departureBoard?id=8600626&format=json"; // All Departures From Kobenhavn H
            //string url = "http://xmlopen.rejseplanen.dk/bin/rest.exe/trip?originId=008600755&destId=008600626&format=json"; //Trekroner to Kobenhavn H
            //string url = "http://xmlopen.rejseplanen.dk/bin/rest.exe/trip?originId=000043003&destId=008600626&format=json"; //Hoje Taastrup to Kobenhavn H
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer(); 
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}