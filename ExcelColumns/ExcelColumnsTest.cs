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
            string column = GetColumn(1);
            Assert.AreEqual("a", column);
        }

        [TestMethod]
        public void ColumnTwentySix()
        {
            string column = GetColumn(26);
            Assert.AreEqual("z", column);
        }
        [TestMethod]
        public void ColumnTwentySeven()
        {
            string column = GetColumn(27);
            Assert.AreEqual("aa", column);
        }

         [TestMethod]
         public void ColumnFiftyTwo()
         {
             string column = GetColumn(52);
             Assert.AreEqual("az", column);
         }
         [TestMethod]
         public void ColumnFiftyThree()
         {
             string column = GetColumn(53);
             Assert.AreEqual("ba", column);
         }
         [TestMethod]
         public void ColumnSeventyEight()
         {
             string column = GetColumn(78);
             Assert.AreEqual("bz", column);
         }
         [TestMethod]
         public void ColumnSeventyNine()
         {
             string column = GetColumn(79);
             Assert.AreEqual("ca", column);
         }
         [TestMethod]
         public void Column703()
         {
             string column = GetColumn(703);
             Assert.AreEqual("aaa", column);
         }
         
        [TestMethod]
        public void ZeroMustReturnA()
        {
            Assert.AreEqual("a", GetPosition(0));
        }
        [TestMethod]
        public void TwentyFiveMustReturnZ()
        {
            Assert.AreEqual("z", GetPosition(25));
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        string GetPosition(int number)
        {
            
            return ((char)('a' + number )).ToString();
        }

        string GetColumn(int columnNumber)
        {
            string column = "";



            while (columnNumber --  > 0 )
            {
                column = GetPosition(columnNumber % 26) + column;
                columnNumber/= 26;
        
            } 
            return column;
        }
    }
}
