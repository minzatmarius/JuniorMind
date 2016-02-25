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
            Alarm[] alarms =  { new Alarm(Day.Monday, 7, 0, true) };
            Assert.IsTrue(IsOn(alarms,Day.Monday, 7, 0));
        }

        [TestMethod]
        public void MultipleAlarms()
        {
            Alarm[] alarms = { new Alarm(Day.Monday | Day.Thursday | Day.Wednesday, 7, 0, true) };
            Assert.IsTrue(IsOn(alarms,Day.Monday, 7, 0)); 
        }

        [TestMethod] 
        public void AlarmShouldTriggerSaturdayToo()
        {
            Alarm[] alarms = { new Alarm(Day.Monday | Day.Thursday | Day.Wednesday, 7, 0, true), new Alarm(Day.Saturday, 9, 0, true) };
            Assert.IsTrue(IsOn(alarms, Day.Monday, 7, 0));
            Assert.IsFalse(IsOn(alarms, Day.Saturday, 7, 0));
            Assert.IsTrue(IsOn(alarms, Day.Saturday, 9, 0));
        }

        [TestMethod]
        public void AlarmShouldNotTrigger()
        {
            Alarm[] alarms = { new Alarm(Day.Monday, 7, 0, true) };
            Assert.IsFalse(IsOn(alarms, Day.Monday, 8, 0));
        }



        [Flags]
        enum Day {
                Sunday = 1,
                Monday = 2,
                Tuesday = 4,    
                Wednesday = 8,
                Thursday = 16,
                Friday = 32,
                Saturday = 64
        }

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


        bool IsOn(Alarm[] alarms, Day day, int hour, int minute)
        {
            bool state = false;
            for(int i = 0; i < alarms.Length; i++)
            {
                state = (day & alarms[i].day) != 0 && hour == alarms[i].hour && alarms[i].minute == minute && alarms[i].state;
                if (state) break;
            }
            return state;
        }
    }
}
