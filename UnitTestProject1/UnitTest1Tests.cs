using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using UnitTestProject1;
using WebApplication3.Controllers;
using Xunit;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1Tests
    {
        //private MockRepository mockRepository;
        private readonly ILogger<WeatherForecastController> _logger;

        public UnitTest1Tests(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public UnitTest1Tests()
        {
            

        }

        private UnitTest1 CreateUnitTest1()
        {
            return new UnitTest1();
        }

        [Fact]
        [TestMethod]
        public void TestMethod1_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitTest1 = new WeatherForecastController();

            // Act
            // Act
            var response = unitTest1.Get();

            // Assert  
            Assert.IsNotNull(response);

            // Assert
            //Assert.IsTrue(false);
            //this..mockRepository.VerifyAll();
        }

        //[Fact]
        //public void TestMethod2_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var unitTest1 = this.CreateUnitTest1();

        //    // Act
        //    unitTest1.TestMethod2();

        //    // Assert
        //    Assert.IsTrue(false);
        //    this.mockRepository.VerifyAll();
        //}
    }
}
