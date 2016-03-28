using System;
using System.Collections;
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

        [TestMethod]
        public void OrderByAverage()
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
            Student[] expected = { student4, student1, student3, student2 };
            SortByAverage(students);

            CollectionAssert.AreEqual(expected, students);
        }

        [TestMethod]
        public void FindStudentsWith7()
        {
            Student student1 = new Student("John", new Subject[] { new Subject("Math", new int[] { 10, 7 }),
                                                                    new Subject("English", new int[]{ 5, 6}) });

            Student student2 = new Student("Alex", new Subject[] { new Subject("Math", new int[] { 5, 5 }),
                                                                    new Subject("English", new int[]{ 5, 6}) });

            Student student3 = new Student("Adriane", new Subject[] { new Subject("Math", new int[] { 5, 8 }),
                                                                    new Subject("English", new int[]{ 8, 6}) });

            Student student4 = new Student("Dan", new Subject[] { new Subject("Math", new int[] { 8, 8}),
                                                                    new Subject("English", new int[]{ 7, 9}) });

            Student student5 = new Student("John", new Subject[] { new Subject("Math", new int[] { 7, 7, 7 }),
                                                                    new Subject("English", new int[]{ 7, 7, 8, 6}) });

            Student[] students = { student1, student2, student3, student4, student5 };
            Student[] expected = { student5, student1 };

            var actual = FindStudentsWith(7, students);
            CollectionAssert.AreEqual(expected, actual);
        }

        Student[] FindStudentsWith(int toFind, Student[] students)
        {
            SortByAverage(students);
            int start = 0;
            int end = students.Length - 1;
            Student[] found = new Student[0];
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (students[mid].GetAverage() == toFind)
                {
                    Array.Resize<Student>(ref found, found.Length + 1);
                    found[found.Length - 1] = students[mid];

                    LookAround(toFind, students, ref found, mid);
                }
                if (students[mid].GetAverage() < toFind)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return found;
        }

        void LookAround(int toFind, Student[] students, ref Student[] found, int mid)
        {
            for (int i = mid + 1; i < students.Length; i++)
            {
                if (students[i].GetAverage() == toFind)
                {
                    Array.Resize<Student>(ref found, found.Length + 1);
                    found[found.Length - 1] = students[i];
                }
                else break;
            }
            for (int i = mid - 1; i >= 0; i--)
            {
                if (students[i].GetAverage() == toFind)
                {
                    Array.Resize<Student>(ref found, found.Length + 1);
                    found[found.Length - 1] = students[i];
                }
                else break;
            }

        }

        void SortByAverage(Student[] students)
        {
            for (int i = 1; i < students.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (students[j].GetAverage() > students[j - 1].GetAverage())
                    {
                        Swap(ref students[j], ref students[j - 1]);
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
                    sum += subject.GetAverage();
                }
                return (double)sum / subjects.Length;
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
            public double GetAverage()
            {
                int sum = 0;
                for(int i = 0; i < marks.Length; i++)
                {
                    sum += marks[i];
                }

                return (double)sum / marks.Length;
            }
        }
    }
}
