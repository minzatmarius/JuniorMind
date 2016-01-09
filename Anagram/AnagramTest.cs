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
        public void TwoDifferentLettersWord()
        {
            int possible = GetPossible("ab");
            Assert.AreEqual(2, possible);
        }
        [TestMethod]
        public void ThreeDifferentLettersWord()
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
        public void TwoLettersWord()
        {
            int possible = GetPossible("aa");
            Assert.AreEqual(1, possible);
        }
        [TestMethod]
        public void ThreeLetterWord()
        {
            int possible = GetPossible("aba");
            Assert.AreEqual(3, possible);
        }
        [TestMethod]
        public void FourLetterWord()
        {
            int possible = GetPossible("abab");
            Assert.AreEqual(6, possible);
        }
        [TestMethod]
        public void LetterEInLetter()
        {
           
            Assert.AreEqual(2, GetNumberOfAppearances('e',"letter"));
        }
        [TestMethod]
        public void ThreeFactorial()
        {

            Assert.AreEqual(6, Factorial(3));
        }


        int GetNumberOfAppearances(char letter, string word)
        {
            int numberOfAppearances = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if(letter == word[i])
                {
                    numberOfAppearances++;
                }
            }
            return numberOfAppearances;
        }

        int Factorial (int number)
        {
            int result = 1;
            while (number > 0)
            {
                result *= number;
                number--;
            }
            return result;
        }

        int GetPossible(string word)
        {
            int denominator = 1;
            for(int i = 'a'; i <= 'z'; i++)
            {
                denominator *= Factorial(GetNumberOfAppearances((char)i, word));
                
            }
            return (Factorial(word.Length)) / denominator;
        }
    }
}
