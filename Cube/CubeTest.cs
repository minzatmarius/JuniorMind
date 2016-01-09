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

        bool IsOK(int number)
        {
            return false;
        }

        int GetNumber(int k)
        {
            return 0;
        }
    }
}
