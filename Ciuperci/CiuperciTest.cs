using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Ciuperci
{
    [TestClass]
    public class CiuperciTest
    {
        [TestMethod]
        public void NumberOfRedMushrooms()
        {
            int red = GetRedMushrooms(10, 4);
            Assert.AreEqual(8, red);
        }

        int GetRedMushrooms(int n, int x)
        {
            return n - (n / (x + 1));
        }

    }
}
