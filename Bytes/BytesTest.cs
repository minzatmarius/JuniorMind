﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes
{
    [TestClass]
    public class BytesTest
    {
        [TestMethod]
        public void ZeroToBinaryShouldBe0()
        {
            byte[] binary = ToBinary(0);
            byte[] expected = { 0 };
            CollectionAssert.AreEqual(expected, binary);

        }
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
        public void ToDecimal1()
        {
            Assert.AreEqual(1, ToDecimal(ToBinary(1)));
        }
        [TestMethod]
        public void ToDecimal2()
        {
            Assert.AreEqual(2, ToDecimal(ToBinary(2)));
        }

        [TestMethod]
        public void ToDecimal6()
        {
            Assert.AreEqual(6, ToDecimal(ToBinary(6)));
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
            CollectionAssert.AreEqual(ToBinary(1), ToBinary(ToDecimal(AND(ToBinary(1), ToBinary(3)))));
        }
        [TestMethod]
        public void OneANDNineShouldBe1()
        {
            //byte[] expected = { 1 };
            CollectionAssert.AreEqual(ToBinary(1), ToBinary(ToDecimal(AND(ToBinary(1), ToBinary(9)))));
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
          //  byte[] expected = { 1, 1 };
            CollectionAssert.AreEqual(ToBinary(3), ToBinary(ToDecimal(OR(ToBinary(1), ToBinary(3)))));
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
          //  byte[] expected = { 1 };
            CollectionAssert.AreEqual(ToBinary(1), ToBinary(ToDecimal(XOR(ToBinary(1), ToBinary(0)))));
        }
        [TestMethod]
        public void OneXORThreeShouldBe2()
        {
           // byte[] expected = { 1, 0 };
            CollectionAssert.AreEqual(ToBinary(2), ToBinary(ToDecimal(XOR(ToBinary(1), ToBinary(3)))));
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
        [TestMethod]
        public void RightShifting8With3PositionsIs1()
        {
            byte[] expected = ToBinary(1);
            byte[] actual = RightHandShift(ToBinary(8), 3);
            CollectionAssert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void RightShifting50With2PositionsIs12()
        {
            byte[] expected = ToBinary(12);
            byte[] actual = RightHandShift(ToBinary(50), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LefttShifting1With3PositionsIs8()
        {
            byte[] expected = ToBinary(8);
            byte[] actual = LeftHandShift(ToBinary(1), 3);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LefttShifting5With2PositionsIs20()
        {
            byte[] expected = ToBinary(20);
            byte[] actual = LeftHandShift(ToBinary(5), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SixIsLessThanSeven()
        {
            Assert.IsTrue(LessThan(6, 7));
        }
        [TestMethod]
        public void SixIsNotLessThanOne()
        {
            Assert.IsFalse(LessThan(6, 1));
        }
        [TestMethod]
        public void TenIsNotLessThanTen()
        {
            Assert.IsFalse(LessThan(10, 10));
        }
        [TestMethod]
        public void GetAt0ShouldReturn3()
        {
            byte[] array = { 1, 2, 3 };
            Assert.AreEqual(3, GetAt(array, 0));
        }
        [TestMethod]
        public void GetAt10ShouldReturn0()
        {
            byte[] array = { 1, 2, 3 };
            Assert.AreEqual(0, GetAt(array, 10));
        }
        [TestMethod]
        public void GetAt2houldReturn1()
        {
            byte[] array = { 1, 2, 3 };
            Assert.AreEqual(1, GetAt(array, 2));
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

        byte GetAt(byte[] array, int position)
        {
            if (position >= array.Length) return 0;
            return array[array.Length - 1 -position];

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
            byte[] result = new byte[Math.Max(binaryNumber1.Length, binaryNumber2.Length)];
            for(int i=0; i < result.Length; i++)
            {
                result[result.Length - 1 - i] = ANDBit(GetAt(binaryNumber1, i), GetAt(binaryNumber2, i));
            }
            return result;
        }

        byte[] OR(byte[] binaryNumber1, byte[] binaryNumber2)
        {
            byte[] result = new byte[Math.Max(binaryNumber1.Length, binaryNumber2.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                result[result.Length - 1 - i] = ORBit(GetAt(binaryNumber1, i), GetAt(binaryNumber2, i));
            }
            return result;
        }

        byte[] XOR(byte[] binaryNumber1, byte[] binaryNumber2)
        {
            byte[] result = new byte[Math.Max(binaryNumber1.Length, binaryNumber2.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                result[result.Length - 1 - i] = XORBit(GetAt(binaryNumber1, i), GetAt(binaryNumber2, i));
            }
            return result;
        }

        byte[] RightHandShift(byte[] binaryNumber, int positions)
        {
            
            while (positions > 0)
            {  
                for(int i = binaryNumber.Length - 1; i>0; i--)
                {
                    binaryNumber[i] = binaryNumber[i - 1];
                }
                binaryNumber[0] = 0;
                positions--;
            }

            return ToBinary(ToDecimal(binaryNumber));
        }

        byte[] LeftHandShift(byte[] binaryNumber, int positions)
        {
                 while (positions > 0)
                 {
                    Array.Resize<byte>(ref binaryNumber, binaryNumber.Length + 1);
                    binaryNumber[binaryNumber.Length - 1] = 0;

                    positions--;
                 }
            return (binaryNumber);
        }

        bool LessThan(int number1, int number2)
        {
            byte[] binaryNumber1 = ToBinary(number1);
            byte[] binaryNumber2 = ToBinary(number2);
            if(binaryNumber1.Length < binaryNumber2.Length)
            {
                return true;
            }
            if (binaryNumber1.Length == binaryNumber2.Length)
            {
                for(int i = 0; i < binaryNumber1.Length; i++)
                {
                    if(binaryNumber1[i] < binaryNumber2[i])
                    {
                        return true;
                    }
                }
            }


            return false;
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

        int ToDecimal(byte[] numberInBinary)
        {
            int number = 0;
            int power = 0;
            for(int i = numberInBinary.Length-1; i>=0; i--)
            {           
                if(numberInBinary[i] != 0)
                {
                    number += (int)Math.Pow(2, power);
                }
                power++;
            }
            return number;
        }

    }
}
