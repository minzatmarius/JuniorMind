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

        [TestMethod]
        public void TestBuzz()
        {
            string answer = GetType(10);
            Assert.AreEqual("Buzz", answer);

        }

        [TestMethod]
        public void TestFizzBuzz()
        {
            string answer = GetType(30);
            Assert.AreEqual("FizzBuzz", answer);

        }

        [TestMethod]
        public void TestNoType()
        {
            string answer = GetType(7);
            Assert.AreEqual("NoType", answer);

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
            return "NoType";
        }
    }
}
