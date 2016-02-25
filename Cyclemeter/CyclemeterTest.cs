using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclemeter
{
    [TestClass]
    public class CyclemeterTest
    {
        [TestMethod]
        public void TotalDistanceForOneCyclist()
        {
            Cyclist cyclist = new Cyclist(1, new Records[]  {new Records(1, 1), new Records(1, 2) });
            Assert.AreEqual(3.14 * 1 * 1, GetDistance(cyclist));
        }

       

        struct Records
        {
            public int rotations;
            public int second;

            public Records(int rotations, int second)
            {
                this.rotations = rotations;
                this.second = second;
            }
        }

        struct Cyclist
        {
            public int diameter;
            public Records[] records;
            public Cyclist(int diameter, Records[] records)
            {
                this.diameter = diameter;
                this.records = records;
            }
        }


           
    }
}
