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
            Section section1 = new Section(new Candidate[] { new Candidate("First", 2), new Candidate("Second", 1) });
            Section section2 = new Section(new Candidate[] { new Candidate("Second", 10), new Candidate("First", 2) });
            Section[] sections = { section1, section2 };

            Candidate[] expected = { new Candidate("Second", 11), new Candidate("First", 4) };
            Candidate[] actual = GetFinalResults(sections);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetVotesForFirst()
        {
            Section section1 = new Section(new Candidate[] { new Candidate("First", 2), new Candidate("Second", 1) });
            Assert.AreEqual(2, GetVotesPerSection(section1, "First"));
        }

        [TestMethod]
        public void GetTotalVotesForFirst()
        {
            Section section1 = new Section(new Candidate[] { new Candidate("First", 2), new Candidate("Second", 1) });
            Section section2 = new Section(new Candidate[] { new Candidate("Second", 10), new Candidate("First", 2) });
            Section[] sections = { section1, section2 };

            Assert.AreEqual(4, GetTotalVotes(sections, "First"));
        }

        int GetVotesPerSection(Section section, string name)
        {

            int result = 0;
            for (int i = 0; i < section.candidates.Length; i++)
            {
                if (section.candidates[i].name == name)
                {
                    result = section.candidates[i].votes;
                    break;
                }
            }
            return result;
        }

        int GetTotalVotes(Section[] sections, string name)
        {
            int results = 0;
            for (int i = 0; i < sections.Length; i++)
            {
                results += GetVotesPerSection(sections[i], name);
            }
            return results;
        }

        void SortCandidates(Candidate[] candidates)
        {
            for (int i = 1; i < candidates.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (candidates[j].votes > candidates[j - 1].votes)
                    {
                        Swap(ref candidates[j], ref candidates[j - 1]);
                    }
                }
            }

        }

        private void Swap(ref Candidate a, ref Candidate b)
        {
            var aux = a;
            a = b;
            b = aux;
        }

        Candidate[] GetFinalResults(Section[] sections)
        {
            Candidate[] results = new Candidate[sections[0].candidates.Length];

            for (int i = 0; i < results.Length; i++)
            {
                results[i].name = sections[0].candidates[i].name;
                results[i].votes = GetTotalVotes(sections, results[i].name);
            }

            SortCandidates(results);
            return results;
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
