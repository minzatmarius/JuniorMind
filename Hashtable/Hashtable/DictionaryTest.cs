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

        [TestMethod]
        public void AddKeyValuePair()
        {
            Hashtable<int, string> table = new Hashtable<int, string>();
            KeyValuePair<int, string> pair1 = new KeyValuePair<int, string>(1, "abc");
            KeyValuePair<int, string> pair2 = new KeyValuePair<int, string>(2, "xyz");
            KeyValuePair<int, string> pair3 = new KeyValuePair<int, string>(1, "x");

            table.Add(pair1);
            table.Add(pair2);
            table.Add(pair3);

            Assert.IsTrue(table.Contains(pair1));
            Assert.IsTrue(table.Contains(pair2));
            Assert.IsTrue(table.Contains(pair3));

        }

        [TestMethod]
        public void TestRemove()
        {
            Hashtable<int, string> table = new Hashtable<int, string>();
            table.Add(1, "abc");
            table.Add(2, "xyz");
            table.Add(1, "def");
            table.Remove(1);
            Assert.IsFalse(table.ContainsKey(1));
        }

        [TestMethod]
        public void TestEnumerator()
        {
            Hashtable<int, string> table = new Hashtable<int, string>();
            table.Add(1, "abc");
            table.Add(2, "xyz");
            table.Add(1, "def");

            int count = 0;
            foreach (KeyValuePair<int, string> pair in table)
            {
                count++;
            }
            Assert.AreEqual(3, count);
        }

      /*  [TestMethod]
        public void TestTryGetValue()
        {
            Hashtable<int, string> table = new Hashtable<int, string>();
            table.Add(1, "abc");//position 1
            table.Add(2, "xyz");//2
            table.Add(1, "def");//3
            table.Add(1, "ghi");//4
            table.Add(2, "XYZ");//5
            table.Add(3, "something");//6
            string value = "def";
            Assert.IsTrue(table.TryGetValue(1, out value));
        }
        */
    }
}
