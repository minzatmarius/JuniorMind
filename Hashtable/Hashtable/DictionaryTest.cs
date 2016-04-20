using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dictionary
{
    [TestClass]
    public class DictionaryTest
    {
        [TestMethod]
        public void TestCount()
        {
            Hashtable < int, string> table = new Hashtable<int, string>();
            Assert.AreEqual(0, table.Count);
        }

        [TestMethod]
        public void TestContainsKey()
        {
            Hashtable<int, string> table = new Hashtable<int, string>();         
            Assert.IsFalse(table.ContainsKey(1));
        }
        [TestMethod]
        public void TestAdd()
        {
            Hashtable<int, string> table = new Hashtable<int, string>();
            table.Add(1, "abc");//position 1
            table.Add(2, "xyz");//2
            table.Add(1, "def");//3
            table.Add(1, "ghi");//4
            table.Add(2, "XYZ");//5
            table.Add(3, "something");//6
            Assert.IsTrue(table.ContainsKey(1));
            Assert.IsTrue(table.ContainsKey(2));
            Assert.IsTrue(table.ContainsKey(3));
        }
    }
}
