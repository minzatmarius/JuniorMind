using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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


        string Shuffle(string input)
        {
            string output = "";
            int currentRandomPosition = 0;
            Random position = new Random();
            while (input.Length > output.Length) {
                for (int i = 0; i < input.Length; i++)
                {
                    currentRandomPosition = input[position.Next(0, input.Length)];
                    output += input[currentRandomPosition];
                
    
                }
            }
          
            return output;
        }
        string GeneratePassword(Password password)
        {
            string result = "";
            Random random = new Random();

            while (password.lowercase > 0)
            {
                char nextCharacter = (char)random.Next(96, 123);
                if (nextCharacter == 'l' || nextCharacter == 'o') continue;
                result += nextCharacter;
                password.lowercase--;
            }

            while (password.uppercase > 0)
            {
                result += (char)random.Next(65, 91);
                password.uppercase--;
            }
            
            while (password.digits > 0)
            {
                result += (char)random.Next(50, 58);
                password.digits--;
            }

            while(password.symbols > 0)
            {
                result += (char)random.Next(33, 48);
                password.symbols--;
            }

            return result;
        }
    }
}
