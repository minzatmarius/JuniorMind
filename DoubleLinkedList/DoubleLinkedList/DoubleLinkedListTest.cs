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
            MyList<int> list = new MyList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            
            int count = 0;
            foreach (Node node in list)
            {
                count++;
            }

            Assert.AreEqual(5,count);
        }

        [TestMethod]
        public void TestContains()
        {
            MyList<int> list = new MyList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            Assert.IsTrue(list.Contains(5));
            Assert.IsFalse(list.Contains(11));
        }
    }
}
