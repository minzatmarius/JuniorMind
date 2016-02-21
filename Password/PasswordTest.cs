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
            Assert.AreEqual(6, GeneratePassword(password).Length);
        }
        [TestMethod]
        public void CheckPassword()
        {
            Password password = new Password(8, 2, 2, 2, 2);
            Assert.AreEqual(password.lowercase, CountLowercase(GeneratePassword(password)));
            Assert.AreEqual(password.uppercase, CountUppercase(GeneratePassword(password)));
            Assert.AreEqual(password.digits, CountDigits(GeneratePassword(password)));
            Assert.AreEqual(password.symbols, CountSymbols(GeneratePassword(password)));

        }
        [TestMethod]
        public void GeneratePassword()
        {
            Password password = new Password(8, 2, 2, 2, 2);
            // Assert.AreEqual(9, GeneratePassword(password).Length);
            Assert.AreEqual("abcdefgh", GeneratePassword(password));
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


        string Shuffle(string input)
        {
            
            Random position = new Random();
            string output = new string(input.OrderBy(r => position.Next()).ToArray());
            return output;
        }
        string GenerateType(int length, int first, int last)
        {
            string result = "";
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                char nextCharacter = (char)random.Next(first, last);
                result += nextCharacter;
            }
            return result;
        }

        string GeneratePassword(Password password)
        {
            string result = "";

            result += GenerateType(password.lowercase, 96, 123);
            result += GenerateType(password.uppercase, 65, 91);
            result += GenerateType(password.digits, 50, 58);
            result += GenerateType(password.symbols, 33, 48);

            return result;
        }
    }
}
