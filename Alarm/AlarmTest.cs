using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alarm
{
    [TestClass]
    public class AlarmTest
    {
        [TestMethod]
        public void AlarmRingsMondayAt7()
        {
            Alarm alarm = new Alarm(Day.Monday, 7, 0, true);
            Assert.IsTrue(IsOn(alarm));
        }

        enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

        struct Alarm
        {
            public Day day;
            public int hour;
            public int minute;
            public bool state;

            public Alarm(Day day, int hour, int minute, bool state)
            {
                this.day = day;
                this.hour = hour;
                this.minute = minute;
                this.state = state;
            }
        }

        bool IsOn(Alarm alarm)
        {
            return alarm.state;
        }
    }
}
