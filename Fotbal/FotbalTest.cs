﻿using System;
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

    }
}
