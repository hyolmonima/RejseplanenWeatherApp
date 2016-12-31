using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RejseplanenWeather.Models;

namespace weatherApp.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        string k = "København H";
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetWeather(string wDestination)
        {
            //if (wDestination.Equals("KÃ¸benhavn H"))
            //{
            //    return Json("Copenhagen");
            //        }
            Weather wData = new Weather();
            wData.destination = wDestination;
            return Json(wData.getWeatherForcast(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult DataReceiver(string wDest)
        {
            return RedirectToAction("GetWeather","Weather", new{wDestination = wDest });
        }

        
    }
}