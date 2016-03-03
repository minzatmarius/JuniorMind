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
            Direction[] points = new Direction[] { new Direction(0, 1, 0, 0), new Direction(0, 0, 1, 0), new Direction(0, 1, 0, 0), new Direction(0, 0, 0, 1), new Direction(1, 0, 0, 0), new Direction(0, 0, 0, 1), new Direction(0, 0, 1, 0) };
            Assert.AreEqual(points[1], FindIntersection(points));
        }

        struct Direction
        {
            public int left;
            public int right;
            public int up;
            public int down;
            public Direction(int left, int right, int up, int down)
            {
                this.left = left;
                this.right = right;
                this.up = up;
                this.down = down;
            }
        }
        bool CheckPoint(int start, Direction[] directions)
        {
            int totalLefts = 0;
            int totalRights = 0;
            int totalUps = 0;
            int totalDowns = 0;
            for(int i = start; i<directions.Length; i++)
            {
                totalLefts += directions[i].left;
                totalRights += directions[i].right;
                totalUps += directions[i].up;
                totalDowns += directions[i].down;

                if (totalLefts - totalRights == 0 && totalUps - totalDowns == 0) break;
            }
            return (totalLefts - totalRights == 0 && totalUps - totalDowns == 0);
        }

        Direction FindIntersection(Direction[] directions)
        {

            for(int i=0; i< directions.Length; i++)
            {
                if (CheckPoint(i, directions))
                {
                    return directions[i];
                }
            }
            return new Direction(0, 0, 0, 0);
        }

    }
}
