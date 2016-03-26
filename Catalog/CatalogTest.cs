using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalog
{
    [TestClass]
    public class CatalogTest
    {
        [TestMethod]
        public void OrderAlphabetically()
        {
            
        }

        void Swap(ref Student a, ref Student b)
        {
            var aux = a;
            a = b;
            b = aux;
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
            public string name;
            public int[] marks;
            public Subject(string name, int[] marks)
            {
                this.name = name;
                this.marks = marks;
            }
        }
    }
}
