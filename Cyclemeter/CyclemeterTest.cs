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
            Cyclist cyclist = new Cyclist("First", 1, new Records[]  {new Records(1, 1), new Records(2, 2) });
            Assert.AreEqual(9.42, GetDistance(cyclist));
        }

        [TestMethod]
        public void TotalDistanceForTwoCyclists()
        {
            Cyclist[] cyclists = { new Cyclist("First", 1, new Records[] { new Records(1, 1), new Records(2, 2) }),
                                 new Cyclist("Second", 1, new Records[] {new Records(1, 1), new Records(2, 2) })};

            Assert.AreEqual(18.84, GetTotalDistance(cyclists));
        }

        [TestMethod]
        public void MaximumSpeedOfOneCyclist()
        {
            Cyclist cyclist = new Cyclist("First", 1, new Records[] { new Records(1, 1), new Records(2, 2) });

            Assert.AreEqual(6.28, GetSpeed(cyclist));
        }

        [TestMethod]
        public void MaximumSpeedOfTwoCyclists()
        {
            Cyclist[] cyclists = { new Cyclist("First", 1, new Records[] { new Records(1, 1), new Records(3, 2) }),
                                 new Cyclist("Second", 1, new Records[] {new Records(1, 1), new Records(2, 2) })};
            Assert.AreEqual(9.42, GetMaximumSpeed(cyclists));
        }

        [TestMethod]
        public void CyclistWithMaximumSpeed()
        {
            Cyclist[] cyclists = { new Cyclist("First", 1, new Records[] { new Records(1, 1), new Records(3, 2) }),
                                 new Cyclist("Second", 1, new Records[] {new Records(1, 1), new Records(2, 2) })};
            Assert.AreEqual("First", GetName(cyclists));

        }

        [TestMethod]
        public void AverageSpeed()
        {
            Cyclist cyclist = new Cyclist("First", 1, new Records[] { new Records(1, 1), new Records(2, 2) });
            Assert.AreEqual(4.71, GetAverageSpeed(cyclist));
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
            public string name;
            public int diameter;
            public Records[] records;
            public Cyclist(string name, int diameter, Records[] records)
            {
                this.name = name;
                this.diameter = diameter;
                this.records = records;
            }
        }

        int GetMaximumRotations(Cyclist cyclist)
        {
            int maximumRotations = cyclist.records[0].rotations;
            for(int i = 1; i < cyclist.records.Length; i++)
            {
                maximumRotations = (maximumRotations < cyclist.records[i].rotations)
                                 ? cyclist.records[i].rotations : maximumRotations; 
            }
            return maximumRotations;
        }

        //Maximum speed of one cyclist
        double GetSpeed(Cyclist cyclist)
        {
            return 3.14 * cyclist.diameter * GetMaximumRotations(cyclist);
        }

        //Maximum speed of all the cyclists
        double GetMaximumSpeed(Cyclist[] cyclists)
        {
            double MaximumSpeed = 0;
            for(int i = 0; i < cyclists.Length; i++)
            {
                MaximumSpeed = (GetSpeed(cyclists[i]) > MaximumSpeed)
                             ? GetSpeed(cyclists[i]) : MaximumSpeed;

            }
            return MaximumSpeed;
        }
        
        String GetName(Cyclist[] cyclists)
        {
            string name = string.Empty;
            double maximumSpeed = GetMaximumSpeed(cyclists);
            for(int i = 0; i < cyclists.Length; i++)
            {
                name += (maximumSpeed == GetSpeed(cyclists[i])) ? cyclists[i].name : "";
            }
            return name;
        }

        double GetAverageSpeed(Cyclist cyclist)
        {
           return GetDistance(cyclist) / cyclist.records.Length;
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
