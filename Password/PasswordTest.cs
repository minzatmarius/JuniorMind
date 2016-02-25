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
            Assert.IsTrue(IsOk(GeneratePassword(password, true)));
        }
        [TestMethod]
        public void LowercaseShouldBe2()
        {
            Password password = new Password(8, 2, 2, 2, 2);
            Assert.AreEqual(password.lowercase, CountLowercase(GeneratePassword(password, true)));
        }

        [TestMethod]
        public void UppercaseShouldBe2()
        {
            Password password = new Password(8, 2, 2, 2, 2);
            Assert.AreEqual(password.uppercase, CountUppercase(GeneratePassword(password, true)));
        }

        [TestMethod]
        public void DigitsShouldBe2()
        {
            Password password = new Password(8, 2, 2, 2, 2);
            Assert.AreEqual(password.digits, CountDigits(GeneratePassword(password, true)));
        }

        [TestMethod]
        public void SymbolsShouldBe2()
        {
            Password password = new Password(8, 2, 2, 2, 2);
            Assert.AreEqual(password.symbols, CountSymbols(GeneratePassword(password, true)));

        }
        [TestMethod]
        public void PsswordShouldNotContainExcludedCharacters()
        {
            Password password = new Password(8, 2, 2, 2, 2);
            Assert.IsTrue(IsOk(GeneratePassword(password, true)));
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

        //Check every character if it should be excluded
        bool IsOk(string password)
        {
            for(int i = 0; i < password.Length; i++)
            {
                if (IsExcluded(password[i])) return false; 
            }
            return true;
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
            return CountType(password, 33, 48) + CountType(password, 58, 65)
                 + CountType(password, 91, 97) + CountType(password, 123, 127);
                
                
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

        bool IsExcluded(char c, string excluded = "oO01lI{}[]()/\\'\"/~/,/;.<> ")
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

        char GenerateRandomCharacter(int first, int last, Random random )
        {
            char randomCharacter = (char)random.Next(first, last);
            while (IsExcluded(randomCharacter))
            {
                randomCharacter = (char)random.Next(first, last);
            }
            return randomCharacter;
        }

        string GenerateSymbols(int symbols, bool shouldExclude)
        {
            string result = string.Empty;
            result += GenerateType(symbols, 33, 48, shouldExclude)
                   + GenerateType(symbols, 58, 65, shouldExclude)
                   + GenerateType(symbols, 91, 97, shouldExclude)
                   + GenerateType(symbols, 123, 127, shouldExclude);
            result = Shuffle(result);

            return result.Substring(0, symbols);
            
            
        }

        string GenerateType(int length, int first, int last, bool shouldExclude)
        {
            string result = "";
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                char nextCharacter = GenerateRandomCharacter(first, last, random);
                result += nextCharacter;                
            }
            return result;
        }


        string GeneratePassword(Password password, bool shouldExclude)
        {
            string result = "";

            result += GenerateType(password.lowercase, 'a', 'z' + 1, shouldExclude);
            result += GenerateType(password.uppercase, 'A', 'Z' + 1, shouldExclude);
            result += GenerateType(password.digits, '0', '9' + 1, shouldExclude);
            //result += GenerateType(password.symbols, 33, 48, exclude);
            result += GenerateSymbols(password.symbols, shouldExclude);

            return Shuffle(result);
        }
    }
}
