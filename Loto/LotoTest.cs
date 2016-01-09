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
        [TestMethod]
        public void ChancesToGetTwoNumbersRightOutOFFive()
        {
            double chance = GetChance(2, 5);
            Assert.AreEqual(0.1, chance);
        }

        double GetChance(int chosenNumbers, int totalNumbers)
        {
            if(chosenNumbers > 1)
            {
                return (chosenNumbers / 1.0 / totalNumbers) * ((chosenNumbers - 1) / 1.0 / (totalNumbers - 1));
            }
       
            return (chosenNumbers/1.0/totalNumbers);

        }
    }
}
