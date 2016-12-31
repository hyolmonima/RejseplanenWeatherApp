using System.Web.Mvc;
using RejseplanenWeather.Models;
using weatherApp.Models;

namespace weatherApp.Controllers
{
    public class TripController : Controller
    {
        // GET: Rejse
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetTrip(string origin, string destination)
        {
            Trip data = new Trip();
            data.baseUrl = string.Format("http://xmlopen.rejseplanen.dk/bin/rest.exe/trip?originId={0}&destId={1}&format=json", origin, destination);
            return Json(data.getTripInfo(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult DataReceiver(string origin, string destination)
        {
            return RedirectToAction("GetTrip", "Trip", new { OriginId = origin, destinationId = destination });
        }
    }
}