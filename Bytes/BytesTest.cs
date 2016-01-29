using System;
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
        public void RightShifting8With1PositionIs4()
        {
            byte[] expected = ToBinary(4);
            byte[] actual = RightHandShift(ToBinary(8), 1);
            CollectionAssert.AreEqual(expected, actual);
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
            Assert.IsTrue(LessThan(ToBinary(6), ToBinary(7)));
        }
        [TestMethod]
        public void SixIsNotLessThanOne()
        {
            Assert.IsFalse(LessThan(ToBinary(6), ToBinary(1)));
        }
        [TestMethod]
        public void TenIsNotLessThanTen()
        {
            Assert.IsFalse(LessThan(ToBinary(10), ToBinary(10)));
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
        [TestMethod]
        public void OnePlusOneIs2()
        {
            byte[] expected = ToBinary(2);
            byte[] actual = Addition(ToBinary(1), ToBinary(1), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OnePlusFourIs5()
        {
            byte[] expected = ToBinary(5);
            byte[] actual = Addition(ToBinary(1), ToBinary(4), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FivePlusFiveIs10()
        {
            byte[] expected = ToBinary(10);
            byte[] actual = Addition(ToBinary(5), ToBinary(5), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FivePlusTwentyIs20()
        {
            byte[] expected = ToBinary(20);
            byte[] actual = Addition(ToBinary(5), ToBinary(15), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TwoMinusOne()
        {
            byte[] expected = ToBinary(1);
            byte[] actual = Subtraction(ToBinary(2), ToBinary(1));
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FourMinusThree()
        {
            byte[] expected = ToBinary(1);
            byte[] actual = Subtraction(ToBinary(4), ToBinary(3));
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FourtyFourMinusThirtyOne()
        {
            byte[] expected = ToBinary(13);
            byte[] actual = Subtraction(ToBinary(44), ToBinary(31));
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TWoSComplementFor1()
        {
            byte[] expected = ToBinary(1);
            byte[] actual = TwoSComplement(ToBinary(1));
        }
        [TestMethod]
        public void TWoSComplementFor3()
        {
            byte[] expected = ToBinary(1);
            byte[] actual = TwoSComplement(ToBinary(1));
        }

        [TestMethod]
        public void TWoSComplementFor13()
        {
            byte[] expected = { 0, 0, 1, 1 };
            byte[] actual = TwoSComplement(ToBinary(13));
        }
        [TestMethod]
        public void OneTimesOne()
        {
            byte[] expected = ToBinary(1);
            byte[] actual = Multiplication(ToBinary(1), ToBinary(1), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TwoTimesTwo()
        {
            byte[] expected = ToBinary(4);
            byte[] actual = Multiplication(ToBinary(2), ToBinary(2), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ThreeTimesFive()
        {
            byte[] expected = ToBinary(15);
            byte[] actual = Multiplication(ToBinary(3), ToBinary(5), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ThreeTimesFiveBaseFive()
        {
            byte[] expected = Convert(15, 5);
            byte[] actual = Multiplication(Convert(3, 5), Convert(5, 5), 5);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ThreeTimesTenBaseSixteen()
        {
            byte[] expected = Convert(30, 16);
            byte[] actual = Multiplication(Convert(3, 16), Convert(10, 16), 16);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ThirtyDividedByTenBaseSixteen()
        {
            byte[] expected = Convert(3, 16);
            byte[] actual = Division(Convert(30, 16), Convert(10, 16), 16);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneDividedByOne()
        {
            byte[] expected = ToBinary(1);
            byte[] actual = Division(ToBinary(1), ToBinary(1), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FourDividedByTwo()
        {
            byte[] expected = ToBinary(2);
            byte[] actual = Division(ToBinary(4), ToBinary(2), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FifteenDividedByThree()
        {
            byte[] expected = ToBinary(5);
            byte[] actual = Division(ToBinary(15), ToBinary(3), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SixteenDividedByThree()
        {
            byte[] expected = ToBinary(5);
            byte[] actual = Division(ToBinary(16), ToBinary(3), 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OneEqualsOne()
        {
            Assert.IsTrue(Equal(ToBinary(1), ToBinary(1)));
        }
        [TestMethod]
        public void TenEqualsTen()
        {
            Assert.IsTrue(Equal(ToBinary(10), ToBinary(10)));
        }
        [TestMethod]
        public void TenIsNotEleven()
        {
            Assert.IsTrue(NotEqual(ToBinary(10), ToBinary(11)));
        }
        [TestMethod]
        public void TenIsGreaterThanOne()
        {
            Assert.IsTrue(GreaterThan(ToBinary(10), ToBinary(1)));
        }
        [TestMethod]
        public void SevenIsGreaterThanSix()
        {
            Assert.IsTrue(GreaterThan(ToBinary(7), ToBinary(6)));
        }
        [TestMethod]
        public void TenInBaseEightIs12()
        {
            byte[] expected = { 1, 2 };
            byte[] actual = Convert(10, 8);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TenInBaseTwoIs1010()
        {
            byte[] expected = { 1, 0, 1, 0 };
            byte[] actual = Convert(10, 2);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TwentyInBaseTwentyIs10()
        {
            byte[] expected = { 1, 0 };
            byte[] actual = Convert(20, 20);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ThirtyInHexadecimalIs114()
        {
            byte[] expected = { 1, 14 };
            byte[] actual = Convert(30, 16);
            CollectionAssert.AreEqual(expected, actual);
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
        byte[] RightHandShiftKeepZeroes(byte[] binaryNumber, int positions)
        {

            while (positions > 0)
            {
                for (int i = binaryNumber.Length - 1; i > 0; i--)
                {
                    binaryNumber[i] = binaryNumber[i - 1];
                }
                binaryNumber[0] = 0;
                positions--;
            }

            return binaryNumber;
        }

        byte[] LeftHandShift(byte[] binaryNumber, int positions)
        {
            Array.Resize<byte>(ref binaryNumber, binaryNumber.Length + positions);
  
            return (binaryNumber);
        }

        bool LessThan(byte[] binaryNumber1, byte[] binaryNumber2)
        {
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

        bool Equal(byte[] binaryNumber1, byte[] binaryNumber2)
        {
            for(int i = 0; i < binaryNumber1.Length; i++)
            {
                if (GetAt(binaryNumber1, i) != GetAt(binaryNumber2, i)) 
                    return false;
            }
            return true;
        }
        bool NotEqual(byte[] binaryNumber1, byte[] binaryNumber2)
        {
            return !(Equal(binaryNumber1, binaryNumber2));
        }
        bool GreaterThan(byte[] binaryNumber1, byte[] binaryNumber2)
        {
            if (((NotEqual(binaryNumber1, binaryNumber2) ) && !(LessThan(binaryNumber1, binaryNumber2))))
                return true;
            return false;
        }

        byte[] Addition(byte[] firstNumber, byte[] secondNumber, byte Base)
        {
            byte[] result = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            byte carry = 0;
            for (int i = 0; i < result.Length; i++)
            {
                byte bitSum = (byte)(GetAt(firstNumber, i) + GetAt(secondNumber, i) + carry);
                result[result.Length - 1 - i] = (byte)(bitSum % Base);

                carry = (byte)((bitSum > Base - 1) ? (1) : 0);
              
            }
            if (carry != 0)
            {
                Array.Resize<byte>(ref result, result.Length + 1);
                result = RightHandShiftKeepZeroes(result, 1);
                result[0] = carry;
            }

            return result;
        }



        byte[] TwoSComplement(byte[] binaryNumber)
        {
            byte[] result = NOT(binaryNumber);     
            result = Addition(result, ToBinary(1), 2);
    
            return result;
        }


        byte[] Subtraction(byte[] binaryNumber1, byte[] binaryNumber2)
        {
             if (Equal(binaryNumber2, ToBinary(1)))
              {

              }

              byte[] result = Addition(binaryNumber1, TwoSComplement(binaryNumber2), 2);

               for(int i = 0; i < result.Length -1; i++)
              {
                  result[i] = result[i + 1];
              }
               Array.Resize<byte>(ref result, result.Length - 1);

              return ToBinary(ToDecimal(result));
              

      
        }

        byte[] Multiplication(byte[] firstNumber, byte[] secondNumber, byte Base)
        {
            byte[] result = new byte[firstNumber.Length];
            byte[] index = { 0 };

            while (LessThan(index, firstNumber))
            {
                result = Addition(result, secondNumber, Base);
                index = Addition(index, Convert(1 ,Base), Base);
            }
            return result;
        }

        byte[] Division(byte[] firstNumber, byte[] secondNumber, byte Base)
        {         
            byte[] result = { 0 };
            byte[] index = secondNumber; ;
            while(LessThan(index,firstNumber))
            {
               // result++;
                result = Addition(result, ToBinary(1), Base);
                index = Addition(index, secondNumber, Base);
                
            }


            return result = (LessThan(firstNumber, index)) ? result : Addition(result, Convert(1, Base), Base);
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

        byte[] Convert(int number, int newBase)
        {
            byte[] newNumber = new byte[0];
            int position = 0;
            while (number != 0)
            {
                Array.Resize<byte>(ref newNumber, newNumber.Length + 1);
                newNumber[position] = (byte)(number % newBase);
                number /= newBase;
                position++;
                
            }
            Array.Reverse(newNumber);
            return newNumber;
        }
    }
}
