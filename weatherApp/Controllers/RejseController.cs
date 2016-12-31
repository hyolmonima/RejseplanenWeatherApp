using System.Web.Mvc;
using RejseplanenWeather.Models;
using weatherApp.Models;

namespace weatherApp.Controllers
{
    public class RejseController : Controller
    {
        // GET: Rejse
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetTrip(string originId, string destinationId)
        {
            origDest data = new origDest();
            data.baseUrl = string.Format("http://xmlopen.rejseplanen.dk/bin/rest.exe/trip?originId={0}&destId={1}&format=json", originId, destinationId);
            return Json(data.getTripInfo(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult DataReceiver(string origin, string destination)
        {
            return RedirectToAction("GetTrip", "Rejse", new { OriginId = origin, destinationId = destination });
        }
    }
}