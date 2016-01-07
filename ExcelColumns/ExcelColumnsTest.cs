using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumns
{
    [TestClass]
    public class ExcelColumnsTest
    {
        [TestMethod]
        public void ColumnOne()
        {
            string column = GetColumn(0);
            Assert.AreEqual("a", column);
        }

        [TestMethod]
        public void ColumnTwentySix()
        {
            string column = GetColumn(25);
            Assert.AreEqual("z", column);
        }
        [TestMethod]
        public void ColumnTwentySeven()
        {
            string column = GetColumn(26);
            Assert.AreEqual("aa", column);
        }
        [TestMethod]
        public void ColumnFiftyTwo()
        {
            string column = GetColumn(51);
            Assert.AreEqual("az", column);
        }
        [TestMethod]
        public void ColumnFiftyThree()
        {
            string column = GetColumn(52);
            Assert.AreEqual("ba", column);
        }

        string GetColumn(int columnNumber)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string column = "";

            while (columnNumber + 1 > alphabet.Length)
            {
                column += alphabet[(columnNumber / alphabet.Length) - 1];
                columnNumber -= (alphabet.Length * (columnNumber / alphabet.Length));
            }

            column += alphabet[columnNumber];
            return column;
        }
    }
}
