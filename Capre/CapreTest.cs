using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capre
{
    [TestClass]
    public class CapreTest
    {
        [TestMethod]
        public void OneGoatInOneDay()
        {
            float Kg = GetKg(1, 1, 1, 1, 1);
            Assert.AreEqual(1, Kg);
        }
        [TestMethod]
        public void TwoGoatsInFiveDays()
        {
            float Kg = GetKg(1, 1, 1, 5, 2);
            Assert.AreEqual(10, Kg);

        }

        [TestMethod]
        public void TwoGoatsInFiveDaysIfOneEatsTwoKgPerDay()
        {
            float Kg = GetKg(1, 1, 2, 5, 2);
            Assert.AreEqual(20, Kg);

        }

        float GetKg(int xDays, int yGoats, float zKg, int wDays, int qGoats)
        {
            float KgPerDay = zKg / xDays / yGoats;
            float TotalKg = KgPerDay * wDays * qGoats;
            return TotalKg;
        }

    }
}
