using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void OneLetterWord()   
        {
            int possible = GetPossible("a");
            Assert.AreEqual(1, possible);
        }
        [TestMethod]
        public void TwoLetterWord()
        {
            int possible = GetPossible("ab");
            Assert.AreEqual(2, possible);
        }
        [TestMethod]
        public void ThreeLetterWord()
        {
            int possible = GetPossible("abc");
            Assert.AreEqual(6, possible);
        }
        [TestMethod]
        public void FiveDifferentLettersWord()
        {
            int possible = GetPossible("abcde");
            Assert.AreEqual(120, possible);
        }
        [TestMethod]
        public void FiveLettersWord()
        {
            int possible = GetPossible("abcab");
            Assert.AreEqual(120, possible);
        }

        int GetPossible(string word)
        {
            int possible = 1;
            int length = word.Length;
            while (length > 0)
            {
                possible *= length;
                length--;
            }
            return possible;
        }
    }
}
