using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Password
{
    [TestClass]
    public class PasswordTest
    {
        [TestMethod]
        public void Generate6Lowercase()
        {
            Password password = new Password(6, 6, 0, 0, 0);
            Assert.AreEqual(6, GeneratePassword(password,true).Length);
        }
        [TestMethod]
        public void CheckPassword()
        {
            Password password = new Password(8, 2, 2, 2, 2);
            Assert.AreEqual(password.lowercase, CountLowercase(GeneratePassword(password, true)));
            Assert.AreEqual(password.uppercase, CountUppercase(GeneratePassword(password, true)));
            Assert.AreEqual(password.digits, CountDigits(GeneratePassword(password, true)));
            Assert.AreEqual(password.symbols, CountSymbols(GeneratePassword(password, true)));

        }
        [TestMethod]
        public void ExcludedCharacters()
        {
            Assert.IsTrue(IsExcluded('{'));
        }

        [TestMethod]
        public void XIsNotExcluded()
        {
            Assert.IsFalse(IsExcluded('X'));
        }

        [TestMethod]
        public void GeneratePassword()
        {
            Password password = new Password(8, 2, 2, 2, 2);
            Assert.AreEqual("abcdefgh", GeneratePassword(password, true));
        }

        [TestMethod]
        public void ShuffleTest()
        {
            string input = "aaBB22@#";
            Assert.AreEqual(input, Shuffle(input));
        }

        struct Password
        {
            public int length;
            public int lowercase;
            public int uppercase;
            public int digits;
            public int symbols;

            public Password(int length, int lowercase, int uppercase, int digits, int symbols)
            {
                this.length = length;
                this.lowercase = lowercase;
                this.uppercase = uppercase;
                this.digits = digits;
                this.symbols = symbols;
            } 
        }
        int CountType(string password, int first, int last)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                count += ((int)password[i] >= first && (int)password[i] < last) ? 1 : 0;
            }
            return count;
        }

        int CountLowercase(string password)
        {
            return CountType(password, 96, 123);
        }

        int CountUppercase(string password)
        {
            return CountType(password, 65, 91);
        }

        int CountDigits(string password)
        {
            return CountType(password, 50, 58);
        }

        int CountSymbols(string password)
        {
            return CountType(password, 33, 48);
        }

        void Swap(ref char first, ref char second)
        {
            char aux = first;
            first = second;
            second = aux;
        }

        string Shuffle(string input)
        {           
            Random random = new Random();
            
            char[] output = input.ToCharArray(0, input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                int firstPosition = random.Next(0, input.Length);
                int secondPosition = random.Next(0, input.Length);
                Swap(ref output[firstPosition], ref output[secondPosition]);
            }
            return new string(output);
        }

        bool IsExcluded(char c, string excluded = "oOlI{}[]()/\\'\"/~/,/;.<> ")
        {
            for (int i = 0; i < excluded.Length; i++)
            {
                if (c == excluded[i])
                {
                    return true;
                }
            }

            return false;
        }

        string GenerateType(int length, int first, int last, bool exclude)
        {
            string result = "";
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                //Generate character
                char nextCharacter = (char)random.Next(first, last);
                //Check if it should be ignored
                if (exclude)
                {
                    if (IsExcluded(nextCharacter))
                    {
                        length++;
                        continue;
                    }
                    result += nextCharacter;
                }
            }
            return result;
        }

        string GeneratePassword(Password password, bool exclude)
        {
            string result = "";

            result += GenerateType(password.lowercase, 96, 123, exclude);
            result += GenerateType(password.uppercase, 65, 91, exclude);
            result += GenerateType(password.digits, 50, 58, exclude);
            result += GenerateType(password.symbols, 33, 48, exclude);

            return result;
        }
    }
}
