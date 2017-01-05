using RejseplanenWeather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace weatherApp.Controllers
{
    public class LocationController : Controller
    {
        // GET: Location
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult OriginLocationService(string originString)
        {
            LocationService loc = new LocationService();
            loc.locationString = originString;
            return Json(loc.getLocation(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult DestinationLocationService(string destinationString)
        {
            LocationService loc = new LocationService();
            loc.locationString = destinationString;
            return Json(loc.getLocation(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult LocationDataReceiver(string locationString1)
        {
            return RedirectToAction("Location", "LocationService", new { locationString = locationString1 });
        }
    }
}