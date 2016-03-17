using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Calculate1()
        {
            int index = 0;
            Assert.AreEqual(1, Calculate("1", ref index));
        }

        [TestMethod]

        public void OnePlusOne()
        {

            int index = 0;
            Assert.AreEqual(2, Calculate("+ 1 1", ref index));
        }

        [TestMethod]
        public void OnePlusOneTimesTwo()
        {
            int index = 0;
            Assert.AreEqual(4, Calculate("* + 1 1 2", ref index));

        }


        [TestMethod]
        public void ComplexOperation()
        {
            int index = 0;
            Assert.AreEqual(10, Calculate("* + 1 1 * 2 2.5", ref index));

        }



        double Calculate(string input, ref int index)
        {
            string[] elements = input.Split(' ');
            string first = elements[index++];

            double number;
            if(Double.TryParse(first, out number))
            {
                return number;
            }

            switch (first)
            {
                case "+": return Calculate(input, ref index) + Calculate(input, ref index);
                case "-": return Calculate(input, ref index) - Calculate(input, ref index);
                case "*": return Calculate(input, ref index) * Calculate(input, ref index);
                default: return Calculate(input, ref index) / Calculate(input, ref index);
            }
        }
    }
}
