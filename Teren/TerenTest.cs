using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teren
{
    [TestClass]
    public class TerenTest
    {
        [TestMethod]
        public void FindLengthForASmallField()
        {
            float length = GetInitialSize(3, 70);
            Assert.AreEqual(7, length, 0.1);
        }

        float GetInitialSize(int newWidth, int area )
        {
            float delta = (newWidth * newWidth) + 4 * area;
            float length1, length2;
            length1 = (float)(-newWidth - Math.Sqrt(delta)) / 2;
            length2 = (float)(-newWidth + Math.Sqrt(delta)) / 2;

            if (length1 >= 0) return length1;
            else return length2;
        }
    }
}
