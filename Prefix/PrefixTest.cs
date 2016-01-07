using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class PrefixTest
    {
        [TestMethod]
        public void CheckForOneCharacter()
        {
            string prefix = GetPrefix("abc", "acb");
            Assert.AreEqual("a", prefix);
        }

        string GetPrefix(string firstString, string secondString)
        {
            string prefix = "";
            prefix += firstString[0];
            return prefix;
        }
    }
}
