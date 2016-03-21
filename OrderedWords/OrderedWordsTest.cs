using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderedWords
{
    [TestClass]
    public class OrderedWordsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "word word word";
            Assert.AreEqual(3, Count("word", input));
        }

        private int Count(string v, string input)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CreateNewStringWithUniqueWords()
        {
            string input = "word word word2";
            Assert.AreEqual("word word2 ", GetWords(input));
        }

        string GetWords(string input)
        {
            string[] words = input.Split(' ');
            string uniqueWords = "";
            for(int i = 0; i < words.Length; i++)
            {
                if (!uniqueWords.Contains(words[i]))
                {
                    uniqueWords += words[i] + " ";
                }
            }

            return uniqueWords;
        }
    }
}
