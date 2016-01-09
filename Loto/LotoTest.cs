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
            double chance = GetChance(1, 1, 5);
            Assert.AreEqual(0.2, chance);
        }
        [TestMethod]
        public void ChancesToGetTwoNumbersRightOutOFFive()
        {
            double chance = GetChance(2, 2, 5);
            Assert.AreEqual(0.1, chance);
        }
        [TestMethod]
        public void ChancesToGet6NumbersRightOutOF49()
        {
            double chance = GetChance(6, 6, 49);
            Assert.AreEqual(1.0/ 13983816, chance, 0.000000000000000001);
        }
        [TestMethod]
        public void ChancesToGet5NumbersRightOutOF49()
        {
            double chance = GetChance(5, 6, 49);
            Assert.AreEqual(0.0000184, chance, 0.0000001);
        }
        [TestMethod]
        public void ChancesToGet4NumbersRightOutOF49()
        {
            double chance = GetChance(4, 6, 49);
            Assert.AreEqual(0.000969, chance, 0.000001);
        }
        [TestMethod]
        public void ChancesToGet5NumbersRightOutOF40()
        {
            double chance = GetChance(5, 5, 40);
            Assert.AreEqual(1.51973836e-6, chance, 0.000001);
        }

        double Factorial(int number)
        {
            double result = 1;
            while (number > 0)
            {
                result *= number;
                number--;
            }
            return result;
        }

        double Combinations(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        double GetChance(int winnerNumbers, int chosenNumbers, int totalNumbers)
        {

            
            double chances = (Combinations(chosenNumbers, winnerNumbers) * 
                Combinations(totalNumbers - chosenNumbers, chosenNumbers - winnerNumbers)) /
                Combinations(totalNumbers, chosenNumbers);
           
            return chances; 
           

        }
    }
}
