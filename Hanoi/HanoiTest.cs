using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hanoi
{
    [TestClass]
    public class HanoiTest
    {
        [TestMethod]
        public void ThreeDisks()
        {
            int[] source = { 1, 2, 3 };
            int[] destination = new int[3];
            MoveDisks(source, destination);
            CollectionAssert.AreEqual(source, new int[] { 0, 0, 0 });
            CollectionAssert.AreEqual(destination, new int[] { 1, 2, 3 });
        }

        void MoveDisks(int[] source, int[] destination)
        {

        }
    }
}
