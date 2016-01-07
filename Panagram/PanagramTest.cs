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

        [TestMethod]
        public void MultipleCharacters()
        {
            bool result = IsPanagram("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual(true, result);
        }

        bool IsPanagram(string phrase)
        {
            string alphabet = "abcde";
            int count = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                for(int j = 0; j < alphabet.Length; j++)
                {
                    if (phrase[i] == alphabet[j])
                    {
                        count++;
                        break;
                    }
                }
            }


            if (count >= alphabet.Length) return true;
            return false;

        }
    }
}
