using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Meteo
{
    [TestClass]
    public class MeteoTest
    {
        [TestMethod]
        public void WarmestDay()
        {
            Data[] days = new Data[] { new Data(0, 8, 10), new Data(1, 7, 11), new Data(2, 9, 9) };
            Assert.AreEqual(days[1], GetWarmestDay(days));

        }
        [TestMethod]
        public void ColdestDay()
        {
            Data[] days = new Data[] { new Data(0, 8, 10), new Data(1, 7, 11), new Data(2, 9, 9) };
            Assert.AreEqual(days[1], GetColdestDay(days));

        }

       

        struct Data
        {
            public int day;
            public int minimum;
            public int maximum;

            public Data(int day, int minimum, int maximum)
            {
                this.day = day;
                this.minimum = minimum;
                this.maximum = maximum;
            }
        }

        Data GetWarmestDay(Data[] days)
        {
            Data maximum = days[0];
            var position = 0;
            for( int i = 1; i < days.Length; i++)
            {
                if(maximum.maximum < days[i].maximum)
                {
                    maximum = days[i];
                    position = i;
                }
            }
            return days[position];
        }

        Data GetColdestDay(Data[] days)
        {
            Data minimum = days[0];
            var position = 0;
            for (int i = 1; i < days.Length; i++)
            {
                if (minimum.minimum > days[i].minimum)
                {
                    minimum = days[i];
                    position = i;
                }
            }
            return days[position];

        }
    }
}
