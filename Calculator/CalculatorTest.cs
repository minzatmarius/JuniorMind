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
            Assert.AreEqual(1, Calculate("1"));
        }

        [TestMethod]
        public void OnePlusOne()
        {         
            Assert.AreEqual(2, Calculate("+ 1 1"));
        }


        double Calculate(string input)
        {
            string[] elements = input.Split(' ');

            double number;
            if(Double.TryParse(elements[0], out number))
            {
                return number;
            }

            switch (elements[0])
            {
                case "+": return Calculate(input.Substring(2)) + Calculate(input.Substring(4));
                case "-": return Calculate(input.Substring(2)) - Calculate(input.Substring(4));
                case "*": return Calculate(input.Substring(2)) * Calculate(input.Substring(4));
                default: return Calculate(input.Substring(2)) / Calculate(input.Substring(2));
            }
        }
    }
}
