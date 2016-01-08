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
        int GetMeetingDay(int first, int second)
        {
            int currentDay = 1;
            

            for (int i=1; ; i ++)
            {
                currentDay++;
                if(i % first == 0 && i % second == 0)
                {
                    break;
                }
                
            }

            return currentDay;
        }
    }
}
