using System;
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
            Vector<int> obj2 = new Vector<int>(new int[] { 1 });
          //  CollectionAssert.AreEqual(obj2, obj);
            
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

    }
}
