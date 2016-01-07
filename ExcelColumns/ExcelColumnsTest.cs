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

        string GetColumn(int columnNumber)
        {
            string alphabet = "abcdefghijklmnopqrstuv";
            string column = "";
            column += alphabet[columnNumber];

            return column;
        }
    }
}
