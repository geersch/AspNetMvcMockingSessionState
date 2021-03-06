using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication;
using MvcApplication.Controllers;
using MvcContrib.TestHelper;

namespace MvcApplication.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Welcome to ASP.NET MVC!", result.ViewBag.Message);
        }

        [TestMethod]
        public void About()
        {
            TestControllerBuilder builder = new TestControllerBuilder();

            // Arrange
            HomeController controller = new HomeController();

            builder.InitializeController(controller);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
