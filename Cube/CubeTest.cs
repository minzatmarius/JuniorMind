using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class CubeTest
    {
        [TestMethod]
        public void FirstNumberShouldBe192()
        {
            int number = GetNumber(1);
            Assert.AreEqual(192, number);
        }
        [TestMethod]
        public void Number888ShouldBeOK()
        {
            bool result = IsOK(888);
            Assert.AreEqual(result, true);
        }

        bool IsOK(int number)
        {
            return (number % 10 == 8 && number / 10 % 10 == 8 && number / 100 % 10 == 8);
        }

        int GetNumber(int k)
        {
            return 0;
        }
    }
}
