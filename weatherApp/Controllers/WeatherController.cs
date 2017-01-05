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

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetWeather(string wDestination)
        {
            Weather wData = new Weather();
            wData.destination = wDestination;
            return Json(wData.getWeatherForcast(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetWeatherByCoordinates(string x, string y)
        {
            Decimal coordX, coordY;
            Decimal.TryParse(x, out coordX);
            var CalculatedX = Math.Truncate((coordX / 1000000) * 100) / 100; //To truncate to two decimal places only.
            Decimal.TryParse(y, out coordY);
            var CalculatedY = Math.Truncate((coordY / 1000000) * 100) / 100;
            WeatherByCoordinates wData = new WeatherByCoordinates();
            wData.x = CalculatedX;
            wData.y = CalculatedY;
            return Json(wData.getWeatherForcast(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult DataReceiver(string wDest)
        {
            return RedirectToAction("GetWeather", "Weather", new { wDestination = wDest });
        }
        
    }
}