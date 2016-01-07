using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTableSqares
{
    [TestClass]
    public class ChessTableSquaresTest
    {
        [TestMethod]
        public void OneByOneTable()
        {
            int squares = GetSquares(1);
            Assert.AreEqual(1, squares);
        }

        [TestMethod]
        public void TwoByTwoTable()
        {
            int squares = GetSquares(2);
            Assert.AreEqual(5, squares);
        }

        [TestMethod]
        public void ThreeByThreeTable()
        {
            int squares = GetSquares(3);
            Assert.AreEqual(14, squares);
        }

        int GetSquares(int tableSize)
        {
            int totalSquares = 0;
            for(int i = tableSize; i > 0; i--)
            {
                totalSquares += i * i;
            }
            return totalSquares;
        }
    }
   
}
