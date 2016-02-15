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
            Point[] points = new Point[] { new Point(0, 1, 0, 0), new Point(0, 0, 1, 0), new Point(0, 1, 0, 0), new Point(0, 0, 0, 1), new Point(1, 0, 0, 0), new Point(0, 0, 0, 1), new Point(0, 0, 1, 0) };
            Assert.AreEqual(points[1], FindIntersection(points));
        }

        struct Point
        {
            public int left;
            public int right;
            public int up;
            public int down;
            public Point(int left, int right, int up, int down)
            {
                this.left = left;
                this.right = right;
                this.up = up;
                this.down = down;
            }
        }
        bool CheckPoint(int start, Point[] points)
        {
            int totalLefts = 0;
            int totalRights = 0;
            int totalUps = 0;
            int totalDowns = 0;
            for(int i = start; i<points.Length; i++)
            {
                totalLefts += points[i].left;
                totalRights += points[i].right;
                totalUps += points[i].up;
                totalDowns += points[i].down;

                if (totalLefts - totalRights == 0 && totalUps - totalDowns == 0) break;
            }
            return (totalLefts - totalRights == 0 && totalUps - totalDowns == 0);
        }

        Point FindIntersection(Point[] points)
        {
            for(int i=0; i< points.Length; i++)
            {
                if (CheckPoint(i, points))
                {
                    return points[i];
                }
            }
            return new Point(0, 0, 0, 0);
        }

    }
}
