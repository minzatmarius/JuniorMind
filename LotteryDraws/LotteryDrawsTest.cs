using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotteryDraws
{
    [TestClass]
    public class LotteryDrawsTest
    {
        [TestMethod]
        public void SortRandomArray()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6 }, BubbleSort(new int[] { 2, 3, 1, 4, 5, 6 }));
        }

        [TestMethod]
        public void SortReversedArray()
        {
            CollectionAssert.AreEqual(new int[] { 12, 21, 33, 40, 45, 46 }, BubbleSort(new int[] { 46, 45, 40, 33, 21, 12}));
        }

        void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        int[] BubbleSort(int[] numbers)
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for(int i = 0; i< numbers.Length - 1; i++)
                {
                    if(numbers[i] > numbers[i + 1])
                    {
                        Swap(ref numbers[i], ref numbers[i + 1]);
                        sorted = false;
                    }
                }
            }

            return numbers;   
        }
    }
}
