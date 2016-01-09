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
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void FiveCharacters()
        {
            bool result = IsPanagram("abcde");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void FiveCharactersRandom()
        {
            bool result = IsPanagram("cbade");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void MultipleCharacters()
        {
            bool result = IsPanagram("The quick brown fox jumps over the lazy dog");
            Assert.AreEqual(true, result);
        }

        int GetNumberOfAppearances(char letter, string phrase)
        {
            int numberOfAppearances = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (letter == phrase[i])
                {
                    numberOfAppearances++;
                }
            }
            return numberOfAppearances;
        }

        bool IsPanagram(string phrase)
        {

            for (int i = 'a'; i <= 'z'; i++)
            {
                if( GetNumberOfAppearances((char)i, phrase) == 0)
                {
                    return false;
                }
            }

            return true ;
           

        }
    }
}
