using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestFizz()
        {
            string answer = GetType(9);
            Assert.AreEqual("Fizz", answer);

        }

        string GetType(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            return "Not a multiple!";
        }
    }
}
