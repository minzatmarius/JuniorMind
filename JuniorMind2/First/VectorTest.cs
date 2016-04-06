﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Vector
{
    [TestClass]
    public class VectorTest
    {
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

    }
}
