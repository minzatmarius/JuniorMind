using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sit
{
    [TestClass]
    public class SitTest
    {
        [TestMethod]
        public void Area()
        {
            float area = GetArea(1, 1, 3, 1, 3, 3);
            Assert.AreEqual(2, area);
        }

        float GetArea(int x1,int y1,int x2, int y2, int x3, int y3)
        {
            float delta = (x1 * y2) + (x2 * y3) + (y1 *x3) - (x3 * y2) - (y3 * x1) - (x2 * y1);
            float area = (Math.Abs(delta)) / 2;
            return area;
        }
    }
}
