using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CifreRomane
{
    [TestClass]
    public class CifreRomaneTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = Convert(1);
            Assert.AreEqual("I", result);

        }

        string Convert(int number)
        {
            return "nothing";
        }
    }
}
