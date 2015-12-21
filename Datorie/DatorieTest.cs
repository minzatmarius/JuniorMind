using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Datorie
{
    [TestClass]
    public class DatorieTest
    {
        [TestMethod]
        public void EightDaysLate()
        {
            decimal sum = GetTotalSum(100, 8);
            Assert.AreEqual(102, sum); 
        }

        [TestMethod]
        public void TwentyDaysLate()
        {
            decimal sum = GetTotalSum(100, 20);
            Assert.AreEqual(105, sum);
        }

        [TestMethod]
        public void VeryLate()
        {
            decimal sum = GetTotalSum(100, 35);
            Assert.AreEqual(110, sum);
        }

        [TestMethod]
        public void NotLate()
        {
            decimal sum = GetTotalSum(100, 0);
            Assert.AreEqual(100, sum);
        }


        decimal GetTotalSum(int rent, int daysLate)
        {
            decimal penalty=0;

            if (daysLate > 30)
            {
                penalty = rent * 0.1m;
            }
            if ((daysLate > 10) && (daysLate < 31))
            {
                penalty = rent * 0.05m;
            }
            if ((daysLate > 0) && (daysLate < 11))
            {
                penalty = rent * 0.02m;
            }
            return rent + penalty;
        }
    }
}
