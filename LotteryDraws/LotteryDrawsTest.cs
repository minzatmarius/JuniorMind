using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotteryDraws
{
    [TestClass]
    public class LotteryDrawsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6 }, Sort(new int[] { 2, 3, 1, 4, 5, 6 }));
        }

        void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        int[] Sort(int[] numbers)
        {
            return numbers;   
        }
    }
}
