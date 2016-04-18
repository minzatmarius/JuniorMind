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
    }
}
