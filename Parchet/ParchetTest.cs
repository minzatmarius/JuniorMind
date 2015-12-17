using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parchet
{
    [TestClass]
    public class ParchetTest
    {
        [TestMethod]
        public void NumberOfBoardsForATwoByOneRoom()
        {
            float boards = GetNumberOfBoards(2, 1, 1, 1);
            Assert.AreEqual(3, boards);
        }


        [TestMethod]
        public void NumberOfBoardsForAFiveByOneRoom()
        {
            float boards = GetNumberOfBoards(5, 1, 1, 1);
            Assert.AreEqual(6, boards);
        }

        [TestMethod]
        public void NumberOfBoardsForATenByOneRoom()
        {
            float boards = GetNumberOfBoards(10, 1, 1, 1);
            Assert.AreEqual(12, boards);
        }

        [TestMethod]
        public void NumberOfBoardsForAFiveByTwoRoom()
        {
            float boards = GetNumberOfBoards(20, 1, 2, 1);
            Assert.AreEqual(12, boards);
        }
        [TestMethod]
        public void NumberOfBoardsForATwentyByOneRoom()
        {
            float boards = GetNumberOfBoards(20, 1, 2, 1);
            Assert.AreEqual(12, boards);
        }


        float GetNumberOfBoards(int n,int m,int a,int b)
        {
       
            return (float) Math.Ceiling(((m / b) * (n / a)) + ((m / b) * (n / a))*0.15f);
        }
    }
}
