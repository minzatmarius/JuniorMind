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
            CollectionAssert.AreEqual(expected, GetLine(2));
        }

        [TestMethod]
        public void ThirdLineIs121()
        {
            int[] expected = { 1, 2, 1 };
            int[] actual = GetLine(3);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Element0Line1()
        {
            Assert.AreEqual(1, GetElement(1, 0));
        }

        [TestMethod]
        public void Element1Line3()
        {
            Assert.AreEqual(2, GetElement(3, 1));
        }

        [TestMethod]
        public void Element1Line4()
        {
            Assert.AreEqual(3, GetElement(4, 1));
        }

        [TestMethod]
        public void Element2Line4()
        {
            Assert.AreEqual(3, GetElement(4, 2));
        }

        [TestMethod]
        public void Element0Line4()
        {
            Assert.AreEqual(1, GetElement(4, 0));
        }

        [TestMethod]
        public void Element3Line4()
        {
            Assert.AreEqual(1, GetElement(4, 3));
        }

        [TestMethod]
        public void Element3Line5()
        {
            Assert.AreEqual(4, GetElement(5, 3));
        }

        [TestMethod]
        public void Element2Line5()
        {
            Assert.AreEqual(6, GetElement(5, 2));
        }

        [TestMethod]
        public void Element3Line7()
        {
            Assert.AreEqual(20, GetElement(7, 3));
        }

        int GetElement(int lineNumber, int position)
        {
            if (position == 0 || position == lineNumber - 1) return 1;
            return GetElement(lineNumber - 1, position - 1) + GetElement(lineNumber - 1, position);
        }

        int[] GetLine(int lineNumber)
        {
            int[] elements = new int[lineNumber]; 
            
            for(int i = 0; i < lineNumber; i++)
            {
                elements[i] = GetElement(lineNumber, i);
            }
          
            return elements;
        }
    }
}
