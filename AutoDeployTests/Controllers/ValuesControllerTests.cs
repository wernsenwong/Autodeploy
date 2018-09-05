using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoDeploy.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDeploy.Controllers.Tests {
    [TestClass()]
    public class ValuesControllerTests {
        private ValuesController valuesController;

        [TestInitialize]
        public void TestInitialize() {
            this.valuesController = new ValuesController();
        }

        [TestMethod()]
        public void TestGetMultiple() {
            var returnResult = valuesController.Get();
            Assert.AreEqual(returnResult.Count(), 2);
        }

        [TestMethod()]
        public void TestGetSingle() {
            var returnResult = valuesController.Get(1);
            Assert.AreEqual(returnResult, "value");
        }
    }
}