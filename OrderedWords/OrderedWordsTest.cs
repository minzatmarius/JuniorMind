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


        [TestMethod]
        public void OrderThreeWords()
        {
            string input = "word word word2";
            Assert.AreEqual("word2 word word", OrderWords(input));
        }

        [TestMethod]
        public void OrderMoreWords()
        {
            string input = "word2 word3 word1 word3 word2 word3";
            Assert.AreEqual("word1 word2 word2 word3 word3 word3", OrderWords(input));
        }
        void Swap(ref string a, ref string b)
        {
            var aux = a;
            a = b;
            b = aux;
        }

        int Count(string word, string input)
        {
            int count = 0;
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word) count++;
            }
            return count;
        }



        string OrderWords(string input)
        {

            string[] words = input.Split(' ');
            for (int i = 1; i < words.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (Count(words[j], input) < Count(words[j - 1], input))
                    {
                        Swap(ref words[j], ref words[j - 1]);
                    }
                }
            }

            return string.Join(" ", words);
        }
    }
}
