using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestRejseplanenWeatherApp
{
    [TestClass]
    public class RecommendationTesting
    {
        [TestMethod]
        public void ShouldReturnRememberYourGoggles()
        {
            var recomController = new RejseplanenWeather.Controllers.HomeController();
        }
    }
   
}
