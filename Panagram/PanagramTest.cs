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

        [TestMethod]
        public void FiveCharactersRandom()
        {
            bool result = IsPanagram("cbade");
            Assert.AreEqual(true, result);
        }

        bool IsPanagram(string phrase)
        {
            string alphabet = "abcde";
            int count = 0;
            int ok = 0;

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (phrase[i] == alphabet[j])
                    {
                        count++;
                        break;
                    }
                }
            }


            if (count == 5) return true;
            return false;

        }
    }
}
