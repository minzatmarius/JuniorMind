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
        [TestMethod]
        public void ChancesToGet6NumbersRightOutOF49()
        {
            double chance = GetChance(6, 49);
            Assert.AreEqual(1.0/ 13983816, chance, 0.000000000000000001);
        }
        [TestMethod]
        public void ChancesToGet5NumbersRightOutOF49()
        {
            double chance = GetChance(5, 49);
            Assert.AreEqual(1.0 / 2330636, chance);
        }

        double GetChance(int chosenNumbers, int totalNumbers)
        {
            double chances = 1;
            while(chosenNumbers > 0)
            {
                chances *= (chosenNumbers / 1.0 / totalNumbers);
                chosenNumbers--;
                totalNumbers--;
            }
            return chances; 
           

        }
    }
}
