using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class FibonacciTest
    {
        
        [TestMethod]
        public void FibonacciOn0()
        {
            Assert.AreEqual(0, GetFibonacci(0));
        }

        [TestMethod]
        public void FibonacciOn1()
        {
            Assert.AreEqual(1, GetFibonacci(1));
        }

        [TestMethod]
        public void FibonacciOn2()
        {
            Assert.AreEqual(1, GetFibonacci(2));
        }

        [TestMethod]
        public void FibonacciOn3()
        {
            // 0 1 1 2 3 5 8 13
            Assert.AreEqual(2, GetFibonacci(3));
        }

        [TestMethod]
        public void FibonacciOn7()
        {
            Assert.AreEqual(13, GetFibonacci(7));
        }

        int GetFibonacci(int number)
        {
            return number < 2 ? number : (GetFibonacci(number - 1) + GetFibonacci(number - 2));
            //if (number < 2) return number;
            //return GetFibonacci(number - 1) + GetFibonacci(number - 2);
        }
    }
}
