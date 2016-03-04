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

        void Increase(ref int totalInOneDirection, Direction first, Direction second)
        {
            totalInOneDirection += (first == second) ? 1 : 0;
        }

        bool IsIntersection(int start, Direction[] directions)
        {
            int totalLefts = 0;
            int totalRights = 0;
            int totalUps = 0;
            int totalDowns = 0;

            for(int i = start; i<directions.Length; i++)
            {

                Increase(ref totalLefts, directions[i], Direction.left);
                Increase(ref totalRights, directions[i], Direction.right);
                Increase(ref totalUps, directions[i], Direction.up);
                Increase(ref totalDowns, directions[i], Direction.down);
         
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
