using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Roman
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckForOne()
        {
            string result = ToRoman(1);
            Assert.AreEqual("i", result); 
        }
        [TestMethod]
        public void CheckForTwo()

        {
            string result = ToRoman(2);
            Assert.AreEqual("ii", result);
        }
        [TestMethod]
        public void CheckForThree()

        {
            string result = ToRoman(3);
            Assert.AreEqual("iii", result);
        }
        [TestMethod]
        public void CheckForTen()

        {
            string result = ToRoman(10);
            Assert.AreEqual("x", result);
        }
        [TestMethod]
        public void CheckForTwentySeven()

        {
            string result = ToRoman(27);
            Assert.AreEqual("xxvii", result);
        }
        [TestMethod]
        public void CheckForFourtyNine()

        {
            string result = ToRoman(49);
            Assert.AreEqual("xlix", result);
        }

        [TestMethod]
        public void CheckForNinetyNine()

        {
            string result = ToRoman(99);
            Assert.AreEqual("xcix", result);
        }

        [TestMethod]
        public void CheckForOneHundred()

        {
            string result = ToRoman(100);
            Assert.AreEqual("c", result);
        }


        string ToRoman(int number)
        {
            string[] RomanNumbers = { "i", "iv", "v", "ix", "x", "xl", "l", "xc", "c" };
            int[] IntegerNumbers = { 1, 4, 5, 9, 10, 40, 50, 90, 100 };
            string output = "";
            for(int i = RomanNumbers.Length - 1; i >= 0; i--)
            {
                while(number - IntegerNumbers[i] >= 0)
                {
                    output += RomanNumbers[i];
                    number -= IntegerNumbers[i];
                }
            }

            return output;
        }
    }
}
