using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Replace
{
    [TestClass]
    public class ReplaceTest
    {
        [TestMethod]
        public void ReplaceXwithICS()
        {
            string originalString = "axe";
            char character = 'x';

            Assert.AreEqual("aICSe", ReplaceCharacter(string original, char c));
        }

        ReplaceCharacter(string original, char c, string replaceWith = "ICS");
    }
}
