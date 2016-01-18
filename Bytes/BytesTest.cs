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
            byte[] expected = { 1 };
            CollectionAssert.AreEqual(expected, binary);

        }
        [TestMethod]
        public void TwoHundredFiftyFourToBinaryShouldBe11111110()
        {
            byte[] binary = ToBinary(254);
            byte[] expected = { 1, 1, 1, 1, 1, 1, 1, 0 };
            CollectionAssert.AreEqual(expected, binary);

        }
        [TestMethod]
        public void TenToBinaryShouldBe1010()
        {
            byte[] binary = ToBinary(10);
            byte[] expected = { 1, 0, 1, 0 };
            CollectionAssert.AreEqual(expected, binary);

        }
        [TestMethod]
        public void TwoHundredToBinaryShouldBe1010()
        {
            byte[] binary = ToBinary(200);
            byte[] expected = { 1, 1, 0, 0, 1, 0, 0, 0 };
            CollectionAssert.AreEqual(expected, binary);

        }
        [TestMethod]
        public void NOTBitZero()
        {
            Assert.AreEqual(1,NOTBit(0));
        }

        [TestMethod]
        public void NOTBitOne()
        {
            Assert.AreEqual(0, NOTBit(1));
        }
        [TestMethod]
        public void NOT1ShouldBe0 ()
        {

            CollectionAssert.AreEqual(NOT(ToBinary(1)), ToBinary(0));
        }

        [TestMethod]
        public void ANDBit1And1()
        {
            Assert.AreEqual(1, ANDBit(1, 1));
        }
        [TestMethod]
        public void ANDBit1And0()
        {
            Assert.AreEqual(0, ANDBit(1, 0));
        }
        [TestMethod]
        public void OneANDOneShouldBe1()
        {
            CollectionAssert.AreEqual(ToBinary(1), AND(ToBinary(1), ToBinary(1)));
        }
        [TestMethod]
        public void OneANDThreeShouldBe1()
        {
            byte[] expected = { 0, 1 };
            CollectionAssert.AreEqual(expected, AND(ToBinary(1), ToBinary(3)));
        }


        [TestMethod]
        public void ORBit1or1()
        {
            Assert.AreEqual(1, ORBit(1, 1));
        }
        [TestMethod]
        public void ORBit1or0()
        {
            Assert.AreEqual(1, ORBit(1, 0));
        }
        [TestMethod]
        public void ORBit0or0()
        {
            Assert.AreEqual(0, ORBit(0, 0));
        }

        [TestMethod]
        public void OneOROneShouldBe1()
        {
            CollectionAssert.AreEqual(ToBinary(1), OR(ToBinary(1), ToBinary(1)));
        }
        [TestMethod]
        public void OneORThreeShouldBe3()
        {
            byte[] expected = { 1, 1 };
            CollectionAssert.AreEqual(expected, OR(ToBinary(1), ToBinary(3)));
        }

        [TestMethod]
        public void XORBit1or1()
        {
            Assert.AreEqual(0, XORBit(1, 1));
        }
        [TestMethod]
        public void XORBit1or0()
        {
            Assert.AreEqual(1, XORBit(1, 0));
        }
        [TestMethod]
        public void XORBit0or0()
        {
            Assert.AreEqual(0, XORBit(0, 0));
        }
        [TestMethod]
        public void OneXOROneShouldBe0()
        {
            CollectionAssert.AreEqual(ToBinary(0), XOR(ToBinary(1), ToBinary(1)));
        }
        [TestMethod]
        public void OneXORZeroShouldBe1()
        {
            byte[] expected = { 1 };
            CollectionAssert.AreEqual(expected, XOR(ToBinary(1), ToBinary(0)));
        }
        [TestMethod]
        public void OneXORThreeShouldBe2()
        {
            byte[] expected = { 1, 0 };
            CollectionAssert.AreEqual(expected, XOR(ToBinary(1), ToBinary(3)));
        }
        [TestMethod]
        public void ArraySizeOf1Is1()
        {
            Assert.AreEqual(1, GetArraySize(1));
        }
        [TestMethod]
        public void ArraySizeOf2Is2()
        {
            Assert.AreEqual(2, GetArraySize(2));
        }
        [TestMethod]
        public void ArraySizeOf8Is4()
        {
            Assert.AreEqual(4, GetArraySize(8));
        }
        [TestMethod]
        public void ArraySizeOf10Is4()
        {
            Assert.AreEqual(4, GetArraySize(10));
        }

        byte NOTBit(byte bit) {
            return (byte)((bit == 1) ? 0 : 1);
        }

        byte ANDBit(byte bit1, byte bit2)
        {
            return (byte)((bit1 == 1 && bit2 == 1) ? 1 : 0);
        }

        byte ORBit(byte bit1, byte bit2)
        {
            return (byte)((bit1 == 1 || bit2 == 1) ? 1 : 0);
        }

        byte XORBit(byte bit1, byte bit2)
        {
            return (byte)((bit1 != bit2) ? 1 : 0);
        }

        int GetArraySize(int number)
        {
            int size = 1;
            while (number / 2 != 0)
            {
                number /= 2;
                size++;
            }
            return size;
        }

        byte[] GreatestOf(byte[] binaryNumber1, byte[] binaryNumber2)
        {

            if (binaryNumber1.Length > binaryNumber2.Length)
            {
                return binaryNumber1;
            }
            return binaryNumber2;
        }
        byte[] SmallestOf(byte[] binaryNumber1, byte[] binaryNumber2)
        {

            if (binaryNumber1.Length < binaryNumber2.Length)
            {
                return binaryNumber1;
            }
            return binaryNumber2;
        }

        byte[] NOT(byte[] binaryNumber)
        {
            byte[] newBinaryNumber = new byte[binaryNumber.Length];
            for(int i = 0; i< binaryNumber.Length; i++)
            {
                newBinaryNumber[i] = NOTBit(binaryNumber[i]);
            }
            return newBinaryNumber;
        }


        byte[] AND(byte[] binaryNumber1, byte[] binaryNumber2)
        {
            int length = GreatestOf(binaryNumber1, binaryNumber2).Length;
            int delta = Math.Abs(binaryNumber1.Length - binaryNumber2.Length);
            byte[] newBinaryNumber = new byte[length];
            for(int i = 0; i < delta; i++)
            {
                newBinaryNumber[i] = ANDBit(GreatestOf(binaryNumber1,binaryNumber2)[i], 0);
            }
            for(int i = delta; i < length; i++)
            {
                newBinaryNumber[i] = ANDBit(SmallestOf(binaryNumber1, binaryNumber2)[i - delta], GreatestOf(binaryNumber1, binaryNumber2)[i]);
            }

            return newBinaryNumber;
        }

        byte[] OR(byte[] binaryNumber1, byte[] binaryNumber2)
        {
            int length = GreatestOf(binaryNumber1, binaryNumber2).Length;
            int delta = Math.Abs(binaryNumber1.Length - binaryNumber2.Length);
            byte[] newBinaryNumber = new byte[length];
            for (int i = 0; i < delta; i++)
            {
                newBinaryNumber[i] = ORBit(GreatestOf(binaryNumber1, binaryNumber2)[i], 0);
            }
            for (int i = delta; i < length; i++)
            {
                newBinaryNumber[i] = ORBit(SmallestOf(binaryNumber1, binaryNumber2)[i - delta], GreatestOf(binaryNumber1, binaryNumber2)[i]);
            }

            return newBinaryNumber;
        }

        byte[] XOR(byte[] binaryNumber1, byte[] binaryNumber2)
        {
            int length = GreatestOf(binaryNumber1, binaryNumber2).Length;
            int delta = Math.Abs(binaryNumber1.Length - binaryNumber2.Length);
            byte[] newBinaryNumber = new byte[length];
            for (int i = 0; i < delta; i++)
            {
                newBinaryNumber[i] = XORBit(GreatestOf(binaryNumber1, binaryNumber2)[i], 0);
            }
            for (int i = delta; i < length; i++)
            {
                newBinaryNumber[i] = XORBit(SmallestOf(binaryNumber1, binaryNumber2)[i - delta], GreatestOf(binaryNumber1, binaryNumber2)[i]);
            }

            return newBinaryNumber;
        }

        byte[] ToBinary(int number)
        {
            byte[] numberInBinary = new byte[GetArraySize(number)];
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
