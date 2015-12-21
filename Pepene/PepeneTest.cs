using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pepene
{
    [TestClass]
    public class PepeneTest
    {
        [TestMethod]
        public void CheckIfSixIsOk()
        {
            string answer = IsEven(6);
            Assert.AreEqual("Yes", answer);
        }
        [TestMethod]
        public void CheckIfSevenIsOk()
        {
            string answer = IsEven(7);
            Assert.AreEqual("No", answer);
        }

        [TestMethod]
        public void CheckIfTwoIsOk()
        {

            string answer = IsEven(2);
            Assert.AreEqual("Yes", answer);
        }

        string IsEven(int kilograms)
        {
            if ((kilograms > 3) && (kilograms % 2 == 0))
            {
                return ("Yes");
            }
            else
            return "No";

        }
    }
}
