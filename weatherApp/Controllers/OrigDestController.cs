using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using weatherApp.Models;

namespace weatherApp.Controllers
{
    public class OrigDestController : Controller
    {
        // GET: OrigDest
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetOrigDest()
        {
            return View();
        }

        public ActionResult DisplayResult()
        {
            origDest obj = new origDest();
            obj.origin = Request.Form["origin"].ToString();
            obj.destination = Request.Form["destination"].ToString();

            ViewData["data"]= obj;
            return View();


        }
    }
}