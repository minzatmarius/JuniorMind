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
            bool result = IsPanagram("The quick brown fox jumps over the lazy dog");
            Assert.AreEqual(true, result);
        }

        int GetNumberOfAppearances(char letter, string word)
        {
            int numberOfAppearances = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (letter == word[i])
                {
                    numberOfAppearances++;
                }
            }
            return numberOfAppearances;
        }

        bool IsPanagram(string phrase)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;

            for (int i = 0; i < alphabet.Length; i++)
            {
                count = GetNumberOfAppearances(alphabet[i], phrase);
            }

            return (count == alphabet.Length) ;
           

        }
    }
}
