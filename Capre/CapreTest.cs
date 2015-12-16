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

        float GetKg(int xDays, int yGoats, float zKg, int wDays, int qGoats)
        {
            float KgPerDay = zKg / xDays / yGoats;
            return KgPerDay * wDays * qGoats;
        }

    }
}
