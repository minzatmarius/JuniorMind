using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Vector
{
    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void TestCount()
        {
            Vector<int> obj = new Vector<int>(new int[] { 1, 2, 3 });
            obj.RemoveAt(2);
            Assert.AreEqual(2, obj.Count);

        }

        [TestMethod]
        public void TestClear()
        {
            Vector<int> obj = new Vector<int>(new int[] { 1, 2, 3 });
            obj.Clear();
            Assert.AreEqual(0, obj.Count);
        }

        [TestMethod]
        public void TestAdd()
        {
            Vector<int> obj = new Vector<int>();
            obj.Add(1);
            Assert.IsTrue(obj.Contains(1));
            
        }

        [TestMethod]
        public void TestContains()
        {
            Vector<int> obj = new Vector<int>(new int[] { 1, 2, 3 });
            Assert.IsTrue(obj.Contains(2));
        }

        [TestMethod]
        public void TestContainsNot()
        {
            Vector<int> obj = new Vector<int>(new int[] { 1, 2, 3 });
            Assert.IsFalse(obj.Contains(4));
        }

        [TestMethod]
        public void TestIndexOf()
        {
            Vector<int> obj = new Vector<int>(new int[] { 1, 2, 3 });
            Assert.AreEqual(1, obj.IndexOf(2));
            Assert.AreEqual(-1, obj.IndexOf(5));
        }

        [TestMethod]
        public void TestInsert()
        {
            Vector<int> obj = new Vector<int>(new int[] { 1, 2, 3 });
            obj.Insert(0, 5);
            Assert.AreEqual(0, obj.IndexOf(5));
            Assert.AreEqual(1, obj.IndexOf(1));
            Assert.AreEqual(3, obj.IndexOf(3));
        }

        [TestMethod]
        public void TestRemoveAt()
        {
            Vector<int> obj = new Vector<int>(new int[] { 1, 2, 3 });
            obj.RemoveAt(0);
            Assert.AreEqual(0, obj.IndexOf(2));
            Assert.IsFalse(obj.Contains(1));
        }

        [TestMethod]
        public void TestRemove()
        {
            Vector<int> obj = new Vector<int>(new int[] { 1, 2, 3 });
            Assert.IsTrue(obj.Remove(2));
            Assert.IsFalse(obj.Remove(4));
        }
    }
}
