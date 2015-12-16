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

        int GetRepetitions(int n)
        {   


            return n+((n-1)*n);
        }
    }
}
