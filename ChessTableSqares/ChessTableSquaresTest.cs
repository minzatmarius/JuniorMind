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

        int GetSquares(int tableSize)
        {
            if (tableSize > 1)
            {
                return tableSize * tableSize + 1;
            }
            return 1;
        }
    }
   
}
