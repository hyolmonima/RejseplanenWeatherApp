using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Json.NET;
using Newtonsoft.Json;

namespace weatherApp.Controllers
{
    public class RecommendationController : Controller
    {
        // GET: Recommendation
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult recommendation(string weatherDescription, string temp, string wind)
        {
            Decimal temp1, wind1;
            Int32 time1;
            Decimal.TryParse(temp, out temp1);
            Decimal.TryParse(wind, out wind1);
            Int32.TryParse(string.Format("{0:HH}", DateTime.Now), out time1);

            if (weatherDescription.Equals("Clear") || weatherDescription.Equals("clear"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    if (time1 <= 10 && time1 >= 16)
                    {
                       return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "sunglass" }, new { item = "wollencap" } } });
                    }
                    else
                    {
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "wollencap" } } });
                    }
                }
                if (temp1 <= 5 & wind1 <= 2)
                {
                    if (time1 <= 10 && time1 >= 16)
                    {
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "sunglass" }, new { item = "wollencap" } } });
                    }
                    else
                    {
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "wollencap" } } });
                    }
                   
                }    
                
                if (temp1 >= 15)
                {
                    return Json(new { message = "", icon = new[] { new { item = "jacket" }, new { item = "sunglass" } } });
                }
                if (temp1 <= 15)
                {
                    return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "sunglass" } } });
                }
            }

           else if (weatherDescription.Equals("rain") || weatherDescription.Equals("Rain"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "raincoat" } } });
                }
                if (temp1 <= 5 & wind1 <= 2)
                {
                    return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "umbrella" } } });
                }
                if (temp1 >= 15)
                {
                    return Json(new { message = "", icon = new[] { new { item = "jacket" }, new { item = "raincoat" } } });
                }
                if (temp1 <= 15)
                {
                    return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "raincoat" } } });
                }
            }

            else if (weatherDescription.Equals("Thunderstorm"))
            {
                if (temp1 <= 5)
                {
                    return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "raincoat" } } });
                }
                if (temp1 <= 15 )
                {
                    return Json(new { message = "", icon = new[] { new { item = "jacket" }, new { item = "raincoat" } } });
                }
                if (temp1 <= 20)
                {
                    return Json(new { message = "", icon = new[] { new { item = "tshirt" }, new { item = "raincoat" } } });
                }
                if (temp1 >= 20)
                {
                    return Json(new { message = "", icon = new[] { new { item = "tshirt" }, new { item = "raincoat" } } });
                }
            }

            else if (weatherDescription.Equals("Drizzle"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    if (time1 >= 10 && time1 <= 17)
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "raincoat" }, new { item = "sunglass" } } });
                    else
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "raincoat" } } });
                }
                if (temp1 <= 5 & wind1 <= 2)
                {
                    return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "raincoat" } } });
                }
                if (temp1 >= 15)
                {
                    return Json(new { message = "", icon = new[] { new { item = "tshirt" }, new { item = "raincoat" } } });
                }
                if (temp1 <= 15)
                {
                    return Json(new { message = "", icon = new[] { new { item = "jacket" }, new { item = "raincoat" } } });
                }
            }

            else if (weatherDescription.Equals("Clouds"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    if (time1 >= 10 && time1 <= 17)
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "wollencap" }, new { item = "sunglass" } } });
                    else
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "wollencap" }} });
                }
                if (temp1 <= 5 & wind1 <= 2)
                {
                    return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "wollencap" }} });
                }
                if (temp1 <= 15 & wind1 >= 3)
                {
                    return Json(new { message = "", icon = new[] { new { item = "jacket" }, new { item = "sunglass" } } });
                }
                if (temp1 >= 16 & wind1 <= 3)
                {
                    return Json(new { message = "Enjoy the Good Weather" });
                }
            }

            else if (weatherDescription.Equals("snow"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    if (time1 >= 10 && time1 <= 17)
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "sunglass" } } });
                    else
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "wollencap" } } });
                }
                else
                {
                    return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "wollencap" } } });
                }
                
            }

            else if (weatherDescription.Equals("Mist"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    if (time1 >= 10 && time1 <= 17)
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "sunglass" } } });
                    else
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "wollencap" } } });
                }
                else
                {
                    return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "wollencap" } } });
                }

            }

            else if (weatherDescription.Equals("Fog") || weatherDescription.Equals("fog"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    if (time1 >= 10 && time1 <= 17)
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" }, new { item = "wollencap" } } });
                    else
                        return Json(new { message = "", icon = new[] { new { item = "downJacket" } } });
                }

            }

            // return Json("message\":\"Every thing is fine. Enjoy !}");
            return new JsonResult  {  Data = new  { message = "Enjoy your Day" }
            };
        }  
    }
}