﻿using System;
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

        [TestMethod]
        public void TestIndexOf()
        {
            MyList<int> list = new MyList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            Assert.AreEqual(0, list.IndexOf(1));
            Assert.AreEqual(3, list.IndexOf(4));
            Assert.AreEqual(4, list.IndexOf(5));
        }

        [TestMethod]
        public void TestRemoveAt()
        {
            MyList<int> list = new MyList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            Assert.AreEqual(5, list.Count);
            list.RemoveAt(4);
            Assert.IsFalse(list.Contains(5));
            Assert.AreEqual(4, list.Count);
        }

        [TestMethod]
        public void TestRemove()
        {
            MyList<int> list = new MyList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            list.Remove(2);
            Assert.IsTrue(list.Remove(2));
            Assert.IsFalse(list.Contains(2));
        }
      
    }
}
