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
            CollectionAssert.AreEqual(expected, GetLine(1));
        }

        [TestMethod]
        public void SecondLineIs11()
        {
            int[] expected = { 1, 1 };
            CollectionAssert.AreEqual(expected, GetLine(2));
        }

        int[] GetLine(int lineNumber)
        {
            int[] elements = new int[lineNumber]; 
            if(lineNumber < 3)
            {
                elements[0] = 1;
                elements[lineNumber - 1] = 1;
                return elements;
            }

            return elements;
        }
    }
}
