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
        [TestMethod]
        public void MediumDistanceDay()
        {
            decimal price = GetPrice(30, 10);
            Assert.AreEqual(240, price);
        }

        [TestMethod]
        public void LongDistanceDay()
        {
            decimal price = GetPrice(100, 10);
            Assert.AreEqual(600, price);
        }

        [TestMethod]
        public void ShortDistanceNight()
        {
            decimal price = GetPrice(10, 10);
            Assert.AreEqual(70, price);

        }


        decimal GetPrice(int distance, int time)
        {
            decimal price;
            decimal pricePerKilometer = 5;

            if (distance > 20)
            {
                pricePerKilometer = 8;
            }
            if (distance > 60)
            {
                pricePerKilometer = 6;
            }
            
            price = pricePerKilometer * distance;
            return price;
        }
    }
}
