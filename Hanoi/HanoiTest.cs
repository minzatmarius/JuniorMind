using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hanoi
{
    [TestClass]
    public class HanoiTest
    {
        [TestMethod]
        public void MoveOneDisk()
        {
            int[] source = { 1 };
            int[] extra = { 0 };
            int[] destination = { 0 };
            MoveDisks(ref source, ref extra, ref destination, 1);
            CollectionAssert.AreEqual(source, new int[] { 0 });
            CollectionAssert.AreEqual(extra, new int[] { 0 });
            CollectionAssert.AreEqual(destination, new int[] { 1 });
        }

        [TestMethod]
        public void ThreeDisks()
        {
            int[] source = { 1, 2, 3 };
            int[] extra = new int[3];
            int[] destination = new int[3];
            MoveDisks(ref source, ref extra , ref destination, 3);
            CollectionAssert.AreEqual(source, new int[] { 0, 0, 0 });
            CollectionAssert.AreEqual(extra, new int[] { 0, 0, 0 });
            CollectionAssert.AreEqual(destination, new int[] { 1, 2, 3 });
        }

        [TestMethod]
        public void SixDisks()
        {
            int[] source = { 1, 2, 3, 4, 5, 6 };
            int[] extra = new int[6];
            int[] destination = new int[6];
            MoveDisks(ref source, ref extra, ref destination, 6);
            CollectionAssert.AreEqual(source, new int[] { 0, 0, 0, 0, 0, 0 });
            CollectionAssert.AreEqual(extra, new int[] { 0, 0, 0, 0, 0, 0 });
            CollectionAssert.AreEqual(destination, new int[] { 1, 2, 3, 4, 5, 6 });
        }

        void MoveDisks(ref int[] source, ref int[] extra, ref int[] destination,  int disk )
        {
            if (disk == 1)
            {
                destination[disk - 1] = source[disk - 1];
                source[disk - 1] = 0;
            }
            else
            {
                //move all the smaller disks on the extra pole
                MoveDisks(ref source, ref destination, ref extra, disk - 1);

                //move this disk on the destination pole
                destination[disk - 1] = disk;
                source[disk - 1] = 0;

                //move the smaller disks on the destination pole
                MoveDisks(ref extra, ref source, ref destination, disk - 1);
            }
        }
    }
}
