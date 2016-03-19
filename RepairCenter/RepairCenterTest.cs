using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepairCenter
{
    [TestClass]
    public class RepairCenterTest
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        public enum Priority
        {
            Low = 1,
            Medium = 2,
            High = 3
        }
        struct Case
        {
            public string name;
            Priority priority;

            public Case(string name, Priority priority)
            {
                this.name = name;
                this.priority = priority;
            }
        }
    }
}
