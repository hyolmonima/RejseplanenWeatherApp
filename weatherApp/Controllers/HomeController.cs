using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RejseplanenWeather.Models;

namespace RejseplanenWeather.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WeatherJS()
        {
            return View();
        }

        public ActionResult DestinationWeather()
        {
            return View();
        }
        public JsonResult GetWeather()
        {
            Weather data = new Weather();
           
            return Json(data.getWeatherForcast(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult WeatherOrNot()
        {
            return View();
        }

        public JsonResult GetTrip()
        {
            Rejseplanen data = new Rejseplanen();
            return Json(data.getTripInfo(), JsonRequestBehavior.AllowGet);
        }

    }
}