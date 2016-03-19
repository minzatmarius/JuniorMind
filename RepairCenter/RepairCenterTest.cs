using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepairCenter
{
    [TestClass]
    public class RepairCenterTest
    {
        [TestMethod]
        public void ThreeCases()
        {
            Case[] cases = new Case[] { new Case("Case1", Priority.Medium),
                                        new Case("Case2", Priority.Low),
                                        new Case("Case3", Priority.High) };

            Case[] expected = new Case[] { cases[2], cases[0], cases[1] };
            CollectionAssert.AreEqual(expected, SortCases(cases));

        }

        void Swap(ref Case a, ref Case b)
        {
            var aux = a;
            a = b;
            b = aux;
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
            public Priority priority;

            public Case(string name, Priority priority)
            {
                this.name = name;
                this.priority = priority;
            }
        }

        Case[] SortCases(Case[] cases)
        {
            for (int i = 1; i < cases.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (cases[j].priority > cases[j - 1].priority)
                    {
                        Swap(ref cases[j], ref cases[j - 1]);
                    }
                }
            }

            return cases;
        }
    }
}
