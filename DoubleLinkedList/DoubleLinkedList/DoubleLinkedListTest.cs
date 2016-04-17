using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DoubleLinkedList
{
    [TestClass]
    public class DoubleLinkedListTest
    {
        [TestMethod]
        public void TestAddLast()
        {
            MyList<int> list = new MyList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            Assert.AreEqual(5,list.Count);           
        }

        [TestMethod]
        public void TestAddFirst()
        {
            MyList<int> list = new MyList<int>();
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
        }

        [TestMethod]
        public void TestEnumerator()
        {
            var list = new MyList<int> { 1, 2, 3, 4, 5 };

            int count = 0;
            foreach (int data in list)
            {
                count++;
            }

            Assert.AreEqual(5,count);
      
    }

        [TestMethod]
        public void TestContains()
        {
            var list = new MyList<int> { 1, 2, 3, 4, 5 };

            Assert.IsTrue(list.Contains(5));
            Assert.IsFalse(list.Contains(11));
        }

        [TestMethod]
        public void TestIndexOf()
        {
            var list = new MyList<int> { 1, 2, 3, 4, 5 };

            Assert.AreEqual(0, list.IndexOf(1));
            Assert.AreEqual(3, list.IndexOf(4));
            Assert.AreEqual(4, list.IndexOf(5));
        }

        [TestMethod]
        public void TestRemoveAt()
        {
            var list = new MyList<int> { 1, 2, 3, 4, 5 };

            Assert.AreEqual(5, list.Count);
            list.RemoveAt(4);
            Assert.IsFalse(list.Contains(5));
            Assert.AreEqual(4, list.Count);
        }

        [TestMethod]
        public void TestRemove()
        {
            var list = new MyList<int> { 1, 2, 3, 4, 5 };

            Assert.IsTrue(list.Remove(2));
            Assert.IsFalse(list.Contains(2));
        }
      
    }
}
