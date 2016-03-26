using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalog
{
    [TestClass]
    public class CatalogTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        struct Student
        {
            public string name;
            public Subject[] subjects;
            public Student(string name, Subject[] subjects)
            {
                this.name = name;
                this.subjects = subjects;
            }
        }
        struct Subject
        {
            public int[] marks;
            public Subject(int[] marks)
            {
                this.marks = marks;
            }
        }
    }
}
