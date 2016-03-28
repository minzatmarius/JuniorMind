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

            QuickSortAplhabetically(students, 0, students.Length - 1);

            CollectionAssert.AreEqual(expected, students);

        }

        [TestMethod]
        public void OrderAlphabeticallyManyStudents()
        {
            Student student1 = new Student("John", new Subject[] { new Subject("Math", new int[] { 10, 7 }),
                                                                    new Subject("English", new int[]{ 5, 6}) });

            Student student2 = new Student("Alex", new Subject[] { new Subject("Math", new int[] { 5, 5 }),
                                                                    new Subject("English", new int[]{ 5, 6}) });

            Student student3 = new Student("Adriane", new Subject[] { new Subject("Math", new int[] { 5, 8 }),
                                                                    new Subject("English", new int[]{ 8, 6}) });

            Student student4 = new Student("Dan", new Subject[] { new Subject("Math", new int[] { 8, 8}),
                                                                    new Subject("English", new int[]{ 7, 9}) });

            Student[] students = { student1, student2, student3, student4 };
            Student[] expected = { student3, student2, student4, student1 };

            QuickSortAplhabetically(students, 0, students.Length - 1);

            CollectionAssert.AreEqual(expected, students);
        }

        [TestMethod]
        public void CalculateAverage()
        {
            Student student1 = new Student("John", new Subject[] { new Subject("Math", new int[] { 10, 7 }),
                                                                    new Subject("English", new int[]{ 5, 6}) });

            Student student2 = new Student("Alex", new Subject[] { new Subject("Math", new int[] { 5, 5 }),
                                                                    new Subject("English", new int[]{ 5, 6}) });


            Assert.AreEqual(7, student1.GetAverage());
            Assert.AreEqual(5.25, student2.GetAverage());

        }


        void OrderAlphabetically(Student[] students)
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < students.Length - 1; i++)
                {
                    if (string.Compare(students[i].name, students[i + 1].name) == -1)
                    {
                        Swap(ref students[i], ref students[i + 1]);
                        sorted = false;
                    }
                }

            }
        }

        void QuickSortAplhabetically(Student[] students, int start, int end)
        {
            int pivot = 0;
            if (start < end)
            {
                pivot = Partition(students, start, end);
                QuickSortAplhabetically(students, start, pivot - 1);
                QuickSortAplhabetically(students, pivot + 1, end);

            }
        }



        private int Partition(Student[] students, int start, int end)
        {
            int pivot = end;
            int cursor = start - 1;

            for (int i = start; i < end; i++)
            {
                if (string.Compare(students[i].name, students[pivot].name) == -1)
                {
                    cursor++;
                    Swap(ref students[cursor], ref students[i]);
                }
            }
            Swap(ref students[cursor + 1], ref students[end]);
            return cursor + 1;
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

            public double GetAverage()
            {
                double sum = 0;
                foreach(Subject subject in subjects)
                {
                    for(int i = 0; i < subject.marks.Length; i++)
                    {
                        sum += subject.marks[i];
                    }
                }
                return (double)sum / subjects.Length / subjects[0].marks.Length;
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
