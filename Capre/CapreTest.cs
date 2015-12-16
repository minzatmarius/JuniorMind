using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capre
{
    [TestClass]
    public class CapreTest
    {
        [TestMethod]
        public void OneGoatInOneDay()
        {
            int Kg = GetKg(1, 1, 1, 1, 1);
            Assert.AreEqual(1, Kg);
        }

        int GetKg(int x, int y, int z, int w, int q)
        {
            return 0;
        }

    }
}
