using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoDeploy.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AutoDeploy.Controllers.Tests {
    [TestClass()]
    public class HomeControllerTests {
        private HomeController homeController;

        [TestInitialize]
        public void TestInitialize() {
            this.homeController = new HomeController();
        }

        [TestMethod()]
        public void IndexTest() {
            var index = homeController.Index() as ViewResult;
            Assert.AreEqual(index.ViewData.First().Value, "Home Page");
        }
    }
}