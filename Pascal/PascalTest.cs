using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pascal
{
    [TestClass]
    public class PascalTest
    {
        [TestMethod]
        public void FirstLineIs1()
        {
            int[] expected = { 1 };
            int[] actual = GetLine(1);
            CollectionAssert.AreEqual(expected, actual );
        }

        [TestMethod]
        public void SecondLineIs11()
        {

            int[] expected = { 1, 1 };
            int[] actual = GetLine(2);
            CollectionAssert.AreEqual(expected, actual );
        }

        [TestMethod]
        public void ThirdLineIs121()
        {
            int[] expected = { 1, 2, 1 };
            int[] actual = GetLine(3);
            CollectionAssert.AreEqual(expected, actual);
        }

        int[] GetLine(int lineNumber)
        {
            int[] elements = new int[lineNumber];
            if (lineNumber == 1) return new int[] { 1 };

            elements[0] = 1;
            elements[lineNumber - 1] = 1;

            int[] previous = GetLine(lineNumber - 1);

            for(int i = 1; i < lineNumber - 1; i++)
            {
                elements[i] = previous[i - 1] + previous[i];
            }
          
            return elements;
        }
    }
}
