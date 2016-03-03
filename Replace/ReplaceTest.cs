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

            Assert.AreEqual("aICSe", ReplaceCharacter(originalString, character));
        }

        string ReplaceCharacter(string original, char character, string replaceWith = "ICS")
        {
            if (original.Length < 2) return original;
            if(original[original.Length - 1] != character)
            {
                replaceWith = "";
            }
            return replaceWith + ReplaceCharacter(original.Remove(original.Length - 1), character);
        }
    }
}
