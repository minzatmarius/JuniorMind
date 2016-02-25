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
            // A cyclist that makes 1 rotation in second 1 and 2 rotations in second 2
            Cyclist cyclist = new Cyclist(1, new Records[]  {new Records(1, 1), new Records(2, 2) });
            Assert.AreEqual(9.42, GetDistance(cyclist));
        }

        [TestMethod]
        public void TotalDistanceForTwoCyclists()
        {
            Cyclist[] cyclists = { new Cyclist(1, new Records[] { new Records(1, 1), new Records(2, 2) }),
                                 new Cyclist(1, new Records[] {new Records(1, 1), new Records(2, 2) })};

            Assert.AreEqual(18.84, GetTotalDistance(cyclists));
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

        double GetTotalDistance(Cyclist[] cyclists)
        {
            double totalDistance = 0;
            for(int i = 0; i < cyclists.Length; i++)
            {
                totalDistance += GetDistance(cyclists[i]);
            }

            return totalDistance;
        }

        double GetDistance(Cyclist cyclist)
        {
            double distance = 0;
            for(int i = 0; i < cyclist.records.Length; i++)
            {
                distance += 3.14 * cyclist.diameter * cyclist.records[i].rotations;
            }

            return distance;
        }
    }
}
