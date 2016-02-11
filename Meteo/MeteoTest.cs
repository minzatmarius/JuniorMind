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
        [TestMethod]
        public void AverageTemperature()
        {
            Data[] days = new Data[] { new Data(0, 8, 10), new Data(1, 7, 11), new Data(2, 9, 9) };
            Assert.AreEqual(10, CalculateAverageTemperature(days));
        }
        [TestMethod]
        public void MaximumDifference()
        {
            Data[] days = new Data[] { new Data(0, 8, 10), new Data(1, 7, 11), new Data(2, 9, 9) };
            Assert.AreEqual(4 , CalculateMaximumDifference(days));

        }
        [TestMethod]
        public void AddAnotherDay()
        {
            Data[] days = new Data[] { new Data(0, 8, 10), new Data(1, 7, 11), new Data(2, 9, 9) };
            CollectionAssert.AreEqual(new Data[] { new Data(0, 8, 10), new Data(1, 7, 11), new Data(2, 9, 9), new Data(3, 11, 13) }, AddDay(days, new Data(3, 11, 13)));
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
            for( int i = 1; i < days.Length; i++)
            {
                if(maximum.maximum < days[i].maximum)
                {
                    maximum = days[i];
                }
            }
            return maximum;
        }

        Data GetColdestDay(Data[] days)
        {
            Data minimum = days[0];
            for (int i = 1; i < days.Length; i++)
            {
                if (minimum.minimum > days[i].minimum)
                {
                    minimum = days[i];
                }
            }
            return minimum;

        }

        double CalculateAverageTemperature(Data[] days)
        {
            double total = 0;
            for(int i = 0; i < days.Length; i++)
            {
                total += days[i].maximum;
            }

            return total / days.Length;
        }

        int CalculateMaximumDifference(Data[] days)
        {
            int difference = days[0].maximum - days[0].minimum;
            int maximumDifference = difference;

            for (int i = 1; i < days.Length; i++)
            {
                difference = days[i].maximum - days[i].minimum;
                maximumDifference = (days[i].maximum - days[i].minimum > maximumDifference) ? difference : maximumDifference;        
            }

            return maximumDifference;
        }
        Data[] AddDay(Data[] days, Data newDay)
        {
            Array.Resize<Data>(ref days, days.Length + 1);
            days[days.Length - 1] = newDay;
            return days;
        }
    }
}
