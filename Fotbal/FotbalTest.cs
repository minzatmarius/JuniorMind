using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fotbal
{
    [TestClass]
    public class FotbalTest
    {
        [TestMethod]
        public void AddLastGame()
        {
            Game[] games = new Game[] { new Game(new Team("TeamA", 2), new Team("TeamB", 1)) };
            Game[] expected = new Game[] { new Game(new Team("TeamA", 2), new Team("TeamB", 1)), new Game(new Team("TeamC", 3), new Team("TeamD", 0)) };
            CollectionAssert.AreEqual(expected, AddGame(games, new Game(new Team("TeamC", 3), new Team("TeamD", 0))));
        }

        [TestMethod]
        public void TotalGoals()
        {
            Game[] games = new Game[] { new Game(new Team("TeamA", 2), new Team("TeamB", 1)), new Game(new Team("TeamC", 3), new Team("TeamD", 0)) };
            Assert.AreEqual(6, GetTotalGoals(games));
        }

        [TestMethod]
        public void TeamWitSmallestRaport()
        {
            Game[] games = new Game[] { new Game(new Team("TeamA", 2), new Team("TeamB", 1)), new Game(new Team("TeamC", 3), new Team("TeamD", 0)) };
            Assert.AreEqual(games[1].teamB, GetTeam(games));
        }

        struct Game
        {
            public Team teamA;
            public Team teamB;
            public Game(Team teamA, Team teamB)
            {
                this.teamA = teamA;
                this.teamB = teamB;
            }
        }

        struct Team
        {
            public string name;
            public int goals;
            public Team(string name, int goals)
            {
                this.name = name;
                this.goals = goals;
            }
        }

        Game[] AddGame(Game[] games, Game lastGame)
        {
            Array.Resize<Game>(ref games, games.Length + 1);
            games[games.Length - 1] = lastGame;
            return games; 
        }

        int GetTotalGoals(Game[] games)
        {
            int total = 0;
            for (int i=0; i < games.Length; i++)
            {
                total += games[i].teamA.goals + games[i].teamB.goals;
            }
            return total;
        }
        
        Team GetTeam(Game[] games)
        {
            Team minimumTeam = games[0].teamA;
            double minimum = 1;
            for(int i=0; i< games.Length; i++)
            {
                double raport = (double)games[i].teamA.goals / games[i].teamB.goals;
                if(raport < minimum)
                {
                    minimum = raport;
                    minimumTeam = games[i].teamA;
                }
                raport = (double)games[i].teamB.goals / games[i].teamA.goals;
                if (raport < minimum)
                {
                    minimum = raport;
                    minimumTeam = games[i].teamB;
                }               
            }
            return minimumTeam;
        }
    }
}
