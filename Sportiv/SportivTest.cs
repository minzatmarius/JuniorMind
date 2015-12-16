using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sportiv
{
    [TestClass]
    public class SportivTest
    {
        [TestMethod]
        public void RepetitionsInTwoRounds()
        {
            int repetitions = GetRepetitions(2);
            Assert.AreEqual(4, repetitions);
        }

        [TestMethod]
        public void RepetitionsInTenRounds()
        {
            int repetitions = GetRepetitions(10);
            Assert.AreEqual(100, repetitions);
        }

        int GetRepetitions(int n)
        {   


            return n+((n-1)*n);
        }
    }
}
