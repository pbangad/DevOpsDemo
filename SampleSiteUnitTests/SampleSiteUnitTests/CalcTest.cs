using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.SampleSiteUnitTests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void AssertAddNumber()
        {
            var calc = new Calc();
            Assert.AreEqual(calc.AddNumbers(1, 2), 10.0);

        }
    }
    //[TestClass]public class Sitetest{[TestMethod] public void AssertButtonInvisible() { Assert.AreEqual(0, 0); } }
}
