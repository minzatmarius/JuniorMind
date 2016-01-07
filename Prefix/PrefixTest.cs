using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class PrefixTest
    {
        [TestMethod]
        public void CheckForOneCharacter()
        {
            string prefix = GetPrefix("abc", "acb");
            Assert.AreEqual("a", prefix);
        }

        [TestMethod]
        public void CheckForTwoCharacters()
        {
            string prefix = GetPrefix("abc", "abx");
            Assert.AreEqual("ab", prefix);
        }

        [TestMethod]
        public void CheckForMultipleCharacters()
        {
            string prefix = GetPrefix("aaab", "aaaabbaa");
            Assert.AreEqual("aaa", prefix);
        }


        string GetPrefix(string firstString, string secondString)
        {
            string prefix = "";
            for(int i = 0; i < firstString.Length; i++)
            {                          
                 if(firstString[i] == secondString[i])
                {
                    prefix += firstString[i];
                }
                else
                {
                    break;
                }
            }
            return prefix;
        }
    }
}
