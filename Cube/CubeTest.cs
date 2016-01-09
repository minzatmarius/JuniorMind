using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class CubeTest
    {
        [TestMethod]
        public void FirstNumberShouldBe192()
        {
            int number = GetNumber(1);
            Assert.AreEqual(192, number);
        }
        [TestMethod]
        public void SecondNumberShouldBe442()
        {
            int number = GetNumber(2);
            Assert.AreEqual(442, number);
        }
        [TestMethod]
        public void Number888ShouldBeOK()
        {
            bool result = IsOK(888);
            Assert.AreEqual(result, true);
        }


        bool IsOK(int number)
        {
            return (number % 1000 == 888);
        }

        int GetNumber(int k)
        {
            int i = 0;
            int totalNumbers = 0;
            while (totalNumbers < k)
            {
                i++;
                if (IsOK(i * i * i))
                {
                    totalNumbers++;
                }
            }
           
            return i;
        }


    }
}
