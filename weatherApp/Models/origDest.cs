﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
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

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            var content = client.DownloadString(baseUrl);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}