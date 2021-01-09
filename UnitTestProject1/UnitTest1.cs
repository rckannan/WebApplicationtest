using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using WebApplication3;
using WebApplication3.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            var controller = new WeatherForecastController();

            // Act
            var actionResult = controller.Get();
            var contentResult = actionResult;

            // Assert
            Assert.IsNotNull(contentResult); 
        }
        [TestMethod]
        public void TestMethod2()
        {

            var controller = new WeatherForecast();

            // Act 
            // Assert
            Assert.IsNotNull(controller);
        }
    }
}
