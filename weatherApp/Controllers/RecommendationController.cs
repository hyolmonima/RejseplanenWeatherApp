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
                        return Json("Please wear Down Jacket and a Wollen Cap");
                    }
                    else
                    {
                        return Json("Please wear Down Jacket, Wollen Cap and Remember to take googles.");
                    }
                }
                if (temp1 <= 5 & wind1 <= 2)
                {
                    if (time1 <= 10 && time1 >= 16)
                    {
                        return Json("Please wear Down Jacket and Wollen Cap");
                    }
                   
                }    
                
                if (temp1 >= 15)
                {
                    return Json("Please wear a thin Jacket and sun goggels");
                }
                if (temp1 <= 15)
                {
                    return Json("Please wear a thick Jacket and sun goggels");
                }
            }

           else if (weatherDescription.Equals("rain") || weatherDescription.Equals("Rain"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    return Json("Please wear Down Jacket and Rain Coat");
                }
                if (temp1 <= 5 & wind1 <= 2)
                {
                    return Json("Please wear Down Jacket and Umbrella" + time1);
                }
                if (temp1 >= 15)
                {
                    return Json("Please wear a normal Jacket and Rain Coat");
                }
                if (temp1 <= 15)
                {
                    return Json("Please wear a Tshirt and Rain Coat");
                }
            }

            else if (weatherDescription.Equals("Thunderstorm"))
            {
                if (temp1 <= 5)
                {
                        return Json("Please wear Down Jacket, RainCoat as there is thunderstorm and temperature is less than 5 Degrees.");
                }
                if (temp1 <= 15 )
                {
                    return Json("Please wear Normal Jacket and Rain Coat");
                }
                if (temp1 <= 20)
                {
                    return Json("Please wear thin Jacket and Rain Coat");
                }
                if (temp1 >= 20)
                {
                   return Json("Please wear a Tshirt and Rain Coat Not Umbrella as there will be Thunderstorm");
                }
            }

            else if (weatherDescription.Equals("Drizzle"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    if (time1 >= 10 && time1 <= 17)
                        return Json("Please wear Down Jacket, Umbrella/ Rain Coat and Do not forget your Goggels");
                    else
                        return Json("Please wear Down Jacket, Umbrella/Rain Coat and No need of googles as it is night");
                }
                if (temp1 <= 5 & wind1 <= 2)
                {
                    return Json("Please wear Down Jacket and No need of goggels in the night" + time1);
                }
                if (temp1 >= 15)
                {
                    return Json("Please wear a normal Jacket and Rain Coat");
                }
                if (temp1 <= 15)
                {
                    return Json("Please wear a Tshirt and Rain Coat");
                }
            }

            else if (weatherDescription.Equals("Clouds"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    if (time1 >= 10 && time1 <= 17)
                        return Json("Please wear Down Jacket");
                    else
                        return Json("Please wear Down Jacket and Torch Light");
                }
                if (temp1 <= 5 & wind1 <= 2)
                {
                    return Json("Please wear Down Jacket ");
                }
                if (temp1 <= 15 & wind1 >= 3)
                {
                    return Json("Please wear a Wind Breaker Jacket");
                }
                if (temp1 >= 16 & wind1 <= 3)
                {
                    return Json("Enjoy the Good Weather");
                }
            }

            else if (weatherDescription.Equals("snow"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    if (time1 >= 10 && time1 <= 17)
                        return Json("Please wear Down Jacket, Snow boots and Do not forget your Goggels as there can be very shiny Snow");
                    else
                        return Json("Please wear Down Jacket, Snow boots and No need of googles as it is night");


                }
                
            }

            else if (weatherDescription.Equals("Mist"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    if (time1 >= 10 && time1 <= 17)
                        return Json("Please wear Down Jacket, Snow boots and Do not forget your Goggels as there can be very shiny Snow");
                    else
                        return Json("Please wear Down Jacket, Snow boots and No need of googles as it is night");


                }

            }

            else if (weatherDescription.Equals("Fog") || weatherDescription.Equals("fog"))
            {
                if (temp1 <= 5 & wind1 >= 2)
                {
                    if (time1 >= 10 && time1 <= 17)
                        return Json("Please wear Down Jacket, Snow boots and Do not forget your Goggels as there can be very shiny Snow");
                    else
                        return Json("Please wear Down Jacket, Snow boots and No need of googles as it is night");


                }

            }

            // return Json("message\":\"Every thing is fine. Enjoy !}");
            return new JsonResult  {  Data = new  { message = "Enjoy your Day",  icon = "enjoy" }
            };
        }  
    }
}