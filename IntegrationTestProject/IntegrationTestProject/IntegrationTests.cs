using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTestProject
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void VerifyMultiply()
        {
            var srv = new sRefCalc.CalcClient();
            Assert.AreEqual(srv.MultiplyNumbers(1, 2), 10.2);

        }
    }
}
