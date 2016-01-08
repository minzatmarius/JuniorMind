using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class LunchTest
    {
        [TestMethod]
        public void IfTheyGoEveryDay()
        {
            int meetingDay = GetMeetingDay(1, 1);
            Assert.AreEqual(2, meetingDay);
        }

        int GetMeetingDay(int first, int second)
        {
            int currentDay = 1;

            return currentDay + first;
        }
    }
}
