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
            Alarm[] alarms = new Alarm[] { new Alarm(Day.Monday, 7, 0, true) };
            CollectionAssert.AreEqual(new bool[] { true }, IsOn(alarms));
        }
        [TestMethod]
        public void MultipleAlarms()
        {
            Alarm[] alarms = new Alarm[] { new Alarm(Day.Monday, 7, 0, true), new Alarm(Day.Tuesday, 7, 0, true), new Alarm(Day.Wednesday, 7, 0, true), new Alarm(Day.Thursday, 7, 0, true), new Alarm(Day.Friday, 7, 0, true), new Alarm(Day.Saturday, 9, 30, true), new Alarm(Day.Monday, 7, 0, false) };
            CollectionAssert.AreEqual(new bool[] { true, true, true, true, true, true, false },IsOn(alarms)); 
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

        bool[] IsOn(Alarm[] alarms)
        {
            bool[] states = new bool[alarms.Length];
            for(int i = 0; i < alarms.Length; i++)
            {
                states[i] = alarms[i].state;
            }
            return states;
        }
    }
}
