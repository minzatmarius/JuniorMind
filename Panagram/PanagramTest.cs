using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class PanagramTest
    {
        [TestMethod]
        public void ThePhraseHasOneCharacter()
        {
            bool result = IsPanagram("a");
            Assert.AreEqual(true, result);
        }

        bool IsPanagram(string phrase)
        {
            string alphabet = "a";
            if(alphabet[0] == phrase[0])
            {
                return true;
            }
            return false;
        }
    }
}
