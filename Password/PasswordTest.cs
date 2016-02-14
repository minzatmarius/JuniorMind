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
        string GeneratePassword(Password password)
        {
            string result = "";
            Random random = new Random();
            while (password.lowercase > 0)
            {
                result += (char)random.Next(97, 123);
                password.lowercase--;
            }
            return result;

        }
    }
}
