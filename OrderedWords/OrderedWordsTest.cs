using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderedWords
{
    [TestClass]
    public class OrderedWordsTest
    {
       


        [TestMethod]
        public void OrderThreeWords()
        {
            string input = "word word word2";
            Word[] expected = new Word[] { new Word("word2", 1), new Word("word", 2)};
            Word[] actual = OrderWords(GetWords(input));

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrderMoreWords()
        {
            string input = "word2 word3 word1 word3 word2 word3";
            Word[] expected = new Word[] { new Word("word1", 1), new Word("word2", 2), new Word("word3", 3) };
            Word[] actual = OrderWords(GetWords(input));

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetWords2()
        {
            string input = "word word word2";
            Word[] expected = new Word[] { new Word("word", 2), new Word("word2", 1) };
            Word[] actual = GetWords(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetWordsAndNumberOfAppearences()
        {
            string input = "word word2 word3 word3 word2 word3";
            Word[] expected = new Word[] { new Word("word", 1), new Word("word2", 2), new Word("word3", 3) };
            Word[] actual = GetWords(input);

            CollectionAssert.AreEqual(expected, actual);

        }

        struct Word {
            public string word;
            public int counter;
            public Word(string word, int counter)
            {
                this.word = word;
                this.counter = counter;
            }
              
        }

        void Swap(ref Word a, ref Word b)
        {
            var aux = a;
            a = b;
            b = aux;
        }

        void Count(Word wordToFind, string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == wordToFind.word) wordToFind.counter++;
            }
        }



        Word[] GetWords(string input)
        {
            string[] words = input.Split(' ');
            string uniqueWords = "";
            Word[] allWords = new Word[0];
          
            for (int i = 0; i<words.Length; i++)
            {
                if (!uniqueWords.Contains(words[i]))
                {
                    uniqueWords += words[i] + " ";
                    Array.Resize<Word>(ref allWords, allWords.Length + 1);
                    allWords[allWords.Length - 1].word = words[i];
                    allWords[allWords.Length - 1].counter++;
                }
                else
                {
                   for(int j = 0; j < allWords.Length; j++)
                    {
                        if(allWords[j].word == words[i])
                        {
                            allWords[j].counter++;
                        }
                    }
                }
            }

            return allWords;
        }

        Word[] OrderWords(Word[] words)
        {

            
            for (int i = 1; i < words.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (words[j].counter < words[j - 1].counter)
                    {
                        Swap(ref words[j], ref words[j - 1]);
                    }
                }
            }

            return  words;
        }
    
    }
}
