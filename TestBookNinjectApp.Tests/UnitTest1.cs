using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestBookNinjectApp.Models;

namespace TestBookNinjectApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IDiscountHelper getTestObject()
        {
            return new MinimumDiscountHelper();
        }
        [TestMethod]
        public void TestMethod1()
        {
            IDiscountHelper target = getTestObject();
            decimal total = 200;
            var discountTotal = target.ApplyDiscount(total);
            Assert.AreEqual(total * 0.9M, discountTotal);
        }
    }
}
