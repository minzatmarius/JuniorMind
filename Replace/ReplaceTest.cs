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

            Assert.AreEqual("aICSe", ReplaceCharacter(originalString, character, "ICS"));
        }

        [TestMethod]
        public void ReplaceKWithKAPPA()
        {
            string originalString = "akbkcdke";
            Assert.AreEqual("aKAPPAbKAPPAcdKAPPAe", ReplaceCharacter(originalString, 'k', "KAPPA"));
        }

        string ReplaceCharacter(string original, char character, string replaceWith )
        {
            if (original.Length < 2)
            {
                return original;
            }
            if (original[original.Length - 1] == character)
            {
                return ReplaceCharacter(original.Substring(0, original.Length -1), character, replaceWith)
                      + replaceWith ;
            }
            return ReplaceCharacter(original.Substring(0, original.Length - 1), character, replaceWith)
                      + original[original.Length - 1];
        }
    }
}
