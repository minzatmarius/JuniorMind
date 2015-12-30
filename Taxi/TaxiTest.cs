using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taxi
{
    [TestClass]
    public class TaxiTest
    {
        [TestMethod]
        public void ShortDistanceDay()
        {
            decimal price = GetPrice(10, 10);
            Assert.AreEqual(50, price);

        }

        decimal GetPrice(int distance, int time)
        {
            return 5 * distance;
        }
    }
}
