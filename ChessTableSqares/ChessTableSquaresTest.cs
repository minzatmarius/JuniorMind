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
            int squares = GetSquaresNeeded(1);
            Assert.AreEqual(1, squares);
        }

        int GetSquaresNeeded(int tableSize)
        {
            return 1;
        }
    }
   
}
