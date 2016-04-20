using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
        [TestMethod]
        public void TestContains()
        {
            Hashtable<int, string> table = new Hashtable<int, string>();
            table.Add(1, "abc");
            KeyValuePair<int, string> pair = new KeyValuePair<int, string>(1, "abc");
            Assert.IsTrue(table.Contains(pair));
        }
        [TestMethod]
        public void TestClear()
        {
            Hashtable<int, string> table = new Hashtable<int, string>();
            table.Add(1, "abc");
            table.Add(2, "xyz");
            table.Add(1, "def");
            table.Clear();
            Assert.IsFalse(table.ContainsKey(1));
        }
    }
}
