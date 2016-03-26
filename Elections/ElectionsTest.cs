using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elections
{
    [TestClass]
    public class ElectionsTest
    {
        [TestMethod]
        public void TwoCandidatesTwoSections()
        {
            Section section1 = new Section(new Candidate[] { new Candidate("First", 2), new Candidate("Second", 1) }) ;
            Section section2 = new Section(new Candidate[] { new Candidate("Second", 10), new Candidate("First",2) });
            Section[] sections = { section1, section2 };

            Candidate[] expected = { new Candidate("Second", 11), new Candidate("First", 4) };
            Candidate[] actual = GetFinalResults(sections);

            CollectionAssert.AreEqual(expected, actual);
        }

        Candidate[] GetFinalResults(Section[] sections)
        {
            throw new NotImplementedException();
        }

        struct Candidate
        {
            public string name;
            public int votes;
            public Candidate(string name, int votes)
            {
                this.name = name;
                this.votes = votes;
            }
        }

        struct Section
        {
            public Candidate[] candidates;
            public Section(Candidate[] candidates)
            {
                this.candidates = candidates;
            }
        }

    }
}
