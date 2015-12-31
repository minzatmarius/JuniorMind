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

        int GetPriceCategory(int distance)
        {

            if (distance > 60)
            {
                return 2;
            }
            if (distance > 20)
            {
                return 1;
            }
            
           
            return 0;
        }

        decimal[] GetPriceTable(int time)
        {
            decimal[] pricePerKilometerDay = { 5, 8, 6 };
            decimal[] pricePerKilometerNight = { 7, 10, 9 };
            if (IsDay(time) == false)
            {
                return pricePerKilometerNight;
            }

            return pricePerKilometerDay;

        }



        decimal GetPricePerKilometer(int distance,int time)
        {
            decimal[] priceTable = GetPriceTable(time);
            int index = GetPriceCategory(distance);
            decimal pricePerKilometer = priceTable[index];
            return pricePerKilometer;
            
        }

        decimal GetPrice(int distance, int time)
        {
            decimal pricePerKilometer = GetPricePerKilometer(distance, time);
            decimal price = pricePerKilometer * distance;
            return price;
        }
        
    }
}
