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
    }
}
