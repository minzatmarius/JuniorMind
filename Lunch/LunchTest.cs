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
        [TestMethod]
        public void IfOneGoesEveryFourDaysAndTheOtherEverySixDays()
        {
            int meetingDay = GetMeetingDay(4, 6);
            Assert.AreEqual(13, meetingDay);
        }
        int GreatestCommonDivider(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else b -= a;
            }
            return a;
        }

        int GetMeetingDay(int first, int second)
        {

            if (first > second)
            {
                return GreatestCommonDivider(first, second) * first+1;
            }


            return GreatestCommonDivider(first, second) * second +1;

        }
    }
}
