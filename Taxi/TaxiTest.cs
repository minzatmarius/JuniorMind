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
            decimal price = GetPrice(10, 23);
            Assert.AreEqual(70, price);

        }

        [TestMethod]
        public void MediumDistanceNight()
        {
            decimal price = GetPrice(30, 23);
            Assert.AreEqual(300, price);

        }

        [TestMethod]
        public void LongDistanceNight()
        {
            decimal price = GetPrice(100, 23);
            Assert.AreEqual(900, price);

        }

        bool IsDay(int time)
        {
            if(time>=8 && time <= 21)
            {
                return true;
            }
            return false;
        }

        decimal GetPrice(int distance, int time)
        {
            decimal price;
            decimal[] pricePerKilometerDay = { 5, 8, 6 };
            decimal[] pricePerKilometerNight = { 7, 10, 9 };
            int index = 0;

            if (distance > 20)
            {
                index = 1;
            }
            if (distance > 60)
            {
                index = 2;
            }
            if(IsDay(time) == false)
            {
                price = pricePerKilometerNight[index] * distance;
            }    
            else
            {
                price = pricePerKilometerDay[index] * distance;
            }       
            return price;
        }
        
    }
}
