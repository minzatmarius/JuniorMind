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
            Word[] expected = new Word[] { new Word("word2", 1), new Word("word", 2) };
            Word[] actual = GetWords(input);
            QuickSortWords(actual, 0, actual.Length - 1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrderMoreWords()
        {
            string input = "word2 word3 word1 word3 word2 word3";
            Word[] expected = new Word[] { new Word("word1", 1), new Word("word2", 2), new Word("word3", 3) };
            Word[] actual = GetWords(input);
            QuickSortWords(actual, 0, actual.Length -1 );

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

        struct Word
        {
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

        void AddWord(ref Word[] allWords, string currentWord)
        {
            Array.Resize<Word>(ref allWords, allWords.Length + 1);
            allWords[allWords.Length - 1].word = currentWord;
            allWords[allWords.Length - 1].counter++;
        }

        void IncreaseCounter(ref Word[] allWords, string currentWord)
        {
            for (int j = 0; j < allWords.Length; j++)
            {
                if (allWords[j].word == currentWord)
                {
                    allWords[j].counter++;
                }
            }
        }

        Word[] GetWords(string input)
        {
            string[] words = input.Split(' ');
            string uniqueWords = "";
            Word[] allWords = new Word[0];

            for (int i = 0; i < words.Length; i++)
            {
                Word currentWord = new Word(words[i], 0);
                if (!uniqueWords.Contains(words[i])) 
                {
                    uniqueWords += words[i] + " ";
                    AddWord(ref allWords, words[i]);

                }
                else
                {
                    IncreaseCounter(ref allWords, words[i]);
                }
            }

            return allWords;
        }

        void QuickSortWords(Word[] words, int start, int end)
        {
            int pivot = 0;
            if(start < end)
            {
                pivot = Partition(words, start, end);
                QuickSortWords(words, start, pivot - 1);
                QuickSortWords(words, pivot + 1, end);

            }
        }

        private int Partition(Word[] words, int start, int end)
        {
            int pivot = end;
            int cursor = start - 1;

            for(int i = start; i< end; i++)
            {
                if(words[i].counter <= words[pivot].counter)
                {
                    cursor++;
                    Swap(ref words[cursor], ref words[i]);
                }
            }
            Swap(ref words[cursor + 1], ref words[end]);
            return cursor + 1;
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

            return words;
        }


    }
}
