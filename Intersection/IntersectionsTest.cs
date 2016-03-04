using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection
{
    [TestClass]
    public class IntersectionsTest
    {
        [TestMethod]
        public void FindTheFirstPoint()
        {
            Direction[] directions = new Direction[] { Direction.right,
                                                    Direction.up,
                                                    Direction.right,
                                                    Direction.down,
                                                    Direction.left,
                                                    Direction.down,
                                                    Direction.up };
            Assert.AreEqual(1, FindIntersection(directions));
        }

        [TestMethod]
        public void FirstIntersectionIsPoint3()
        {
            Direction[] directions = new Direction[]
            {
                Direction.right,
                Direction.right,
                Direction.right,
                Direction.right,
                Direction.left
            };
            Assert.AreEqual(3, FindIntersection(directions));
        }
        [TestMethod]
        public void FirstIntersectionIsPoint0()
        {
            Direction[] directions = new Direction[]
            {
                Direction.right,
                Direction.down,
                Direction.left,
                Direction.up
            };
            Assert.AreEqual(0, FindIntersection(directions));

        }

       
        [Flags]
        enum Direction
        {
            left = 1,
            right = 2,
            up = 4,
            down = 8
        }

        bool IsIntersection(int start, Direction[] directions)
        {
            int totalLefts = 0;
            int totalRights = 0;
            int totalUps = 0;
            int totalDowns = 0;

            for(int i = start; i<directions.Length; i++)
            {
                if (directions[i] == Direction.left)  totalLefts += 1;
                if (directions[i] == Direction.right) totalRights += 1;
                if (directions[i] == Direction.up) totalUps += 1;
                if (directions[i] == Direction.down) totalDowns += 1;
            
                if (totalLefts - totalRights == 0 && totalUps - totalDowns == 0) break;
            }
            return (totalLefts - totalRights == 0 && totalUps - totalDowns == 0);
        }

        int FindIntersection(Direction[] directions)
        {

            for(int i=0; i< directions.Length; i++)
            {
                if (IsIntersection(i, directions))
                {
                    return i;
                }
            }
            return 0;
        }

    }
}
