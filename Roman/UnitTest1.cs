using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Roman
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckForOne()
        {
            string result = ToRoman(1);
            Assert.AreEqual("i", result); 
        }

        string ToRoman(int number)
        {

            return "";
        }
    }
}
