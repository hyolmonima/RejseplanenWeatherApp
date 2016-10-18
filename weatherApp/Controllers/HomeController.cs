using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RejseplanenWeather.Models;
using weatherApp.Models;
using System.Net;
using System.Web.Script.Serialization;

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

        public ActionResult form()
        {

            return View();
        }

        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult OrigDestInput()
        //{
        //    origDest data = new origDest();
        //    data.origin = Request.Form["origin"];
        //    data.destination = Request.Form["destination"];
        //    return RedirectToAction("WeatherOrNot", "Home", new { origin = data.origin, destination = data.destination });
        //}
        public ActionResult WeatherOrNot()

        {
            origDest obj = new origDest();
            obj.origin = Request.Form["origin"].ToString();
            obj.destination = Request.Form["destination"].ToString();
            return RedirectToAction("GetTrip", "Home", new { origin = obj.origin, destination = obj.destination });
           // return Content(obj.origin, obj.destination);
 }


        public JsonResult GetTrip(string origin, string destination)
        {
            origDest obj = new origDest();
            obj.origin = origin;
            obj.destination = destination;
          // obj.origin = Request.Form["origin"].ToString();
           // obj.destination = Request.Form["destination"].ToString();
            //origDest data = new origDest();
            return Json(obj.getTripInfo(), JsonRequestBehavior.AllowGet);
        }
    }
}

       