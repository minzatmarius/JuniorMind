using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderedWords
{
    [TestClass]
    public class OrderedWordsTest
    {
        [TestMethod]
        public void CountWords()
        {
            string input = "word word word";
            Assert.AreEqual(3, Count("word", input));
        }

        int Count(string word, string input)
        {
            int count = 0;
            string[] words = input.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i] == word) count++;
            }
            return count;
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
