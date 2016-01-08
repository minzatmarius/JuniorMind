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

        int GetPossible(string word)
        {
            return word.Length;
        }
    }
}
