using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fotbal
{
    [TestClass]
    public class FotbalTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        struct Game
        {
            Team teamA;
            Team teamB;
        }
        struct Team
        {
            string name;
            int goals;
        }


    }
}
