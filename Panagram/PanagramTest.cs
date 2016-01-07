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

        [TestMethod]
        public void FiveCharacters()
        {
            bool result = IsPanagram("abcde");
            Assert.AreEqual(true, result);
        }

        bool IsPanagram(string phrase)
        {
            string alphabet = "abcde";
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                if (alphabet[i] == phrase[i])
                {
                    count++;
                }
            }
            if (count == 5) return true;
            return false;

        }
    }
}
