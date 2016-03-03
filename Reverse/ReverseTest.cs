using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reverse
{
    [TestClass]
    public class ReverseTest
    {
        [TestMethod]
        public void ReverseAB()
        {
            Assert.AreEqual("ba", ReverseString("ab"));
        }

        [TestMethod]
        public void ReverseABCDE()
        {
            Assert.AreEqual("edcba", ReverseString("abcde"));
        }

        string ReverseString(string input)
        {
            string output = string.Empty;
            if (input.Length < 2) return input;
            
            return input[input.Length - 1] + ReverseString(input.Remove(input.Length - 1));

        }
    }
}
