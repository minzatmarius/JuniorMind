using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes
{
    [TestClass]
    public class BytesTest
    {
        [TestMethod]
        public void OneToBinaryShouldBe1()
        {
            byte[] binary = ToBinary(1);
            byte[] expected = { 0, 0, 0, 0, 0, 0, 0, 1 };
            CollectionAssert.AreEqual(expected, binary);

        }
        [TestMethod]
        public void TenToBinaryShouldBe1010()
        {
            byte[] binary = ToBinary(10);
            byte[] expected = { 0, 0, 0, 0, 1, 0, 1, 0 };
            CollectionAssert.AreEqual(expected, binary);

        }

        byte[] ToBinary(int number)
        {
            byte[] numberInBinary = new byte[8];
            int position = numberInBinary.Length - 1;
            while (number != 0)
            {
                numberInBinary[position] = (byte)(number % 2);
                number /= 2;
                position--;
            }

            return numberInBinary ;
        }
    }
}
