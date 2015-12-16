using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pavaj
{
    [TestClass]
    public class PavajTest
    {
        [TestMethod]
        public void CubesNeededForATwoByTwoMarket()
        {
            int cubes = GetNumberOfCubes(2, 2, 1);
            Assert.AreEqual(4, cubes);
        }
        [TestMethod]
        public void CubesNeededForAThreeByFour()
        {
            int cubes = GetNumberOfCubes(3, 4, 1);
            Assert.AreEqual(12, cubes);
        }

        int GetNumberOfCubes(int m, int n, int a) {
            if (m % a != 0)
                { m += a; }
            if (n % a != 0)
                { n += a; }

            return (m * n) / a;
        }
    }
}
