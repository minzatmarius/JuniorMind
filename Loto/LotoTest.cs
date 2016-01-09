using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class LotoTest
    {
        [TestMethod]
        public void ChancesToGetOneNumberRightOutOFFive()
        {
            double chance = GetChance(1, 5);
            Assert.AreEqual(0.2, chance);
        }

        double GetChance(int chosenNumbers, int totalNumbers)
        {
            return (chosenNumbers/1.0/totalNumbers);
        }
    }
}
