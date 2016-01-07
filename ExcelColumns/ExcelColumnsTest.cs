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
        string GetColumn(int columnNumber)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string column = "";
            column += alphabet[columnNumber];

            return column;
        }
    }
}
