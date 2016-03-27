using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalog
{
    [TestClass]
    public class CatalogTest
    {
        [TestMethod]
        public void OrderAlphabeticallyTwoStudents()
        {
            Student student1 = new Student("John", new Subject[] { new Subject("Math", new int[] { 10, 7 }),
                                                                    new Subject("English", new int[]{ 5, 6}) });


            Student student2 = new Student("Alex", new Subject[] { new Subject("Math", new int[] { 5, 5 }),
                                                                    new Subject("English", new int[]{ 5, 6}) });

            Student[] students = { student1, student2 };
            Student[] expected = { student2, student1 };

            OrderAlphabetically(students);
            CollectionAssert.AreEqual(expected, students);
        

        }

        string CompareStrings(string first,string second)
        {
            for(int i = 0; i < first.Length; i++)
            {
                if((int)first[i] > (int)second[i])
                {
                    return second;
                }
            }

            return first;
        }

        void OrderAlphabetically(Student[] students)
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
