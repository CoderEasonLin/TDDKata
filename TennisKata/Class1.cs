using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TennisKata
{
    [TestFixture]
    public class TennisKataTests
    {
        [Test]
        public void GameStartScoreShouldBe0vs0()
        {
            var game = new TennisGame();

            var expected = "0:0";

            Assert.AreEqual(expected, game.Score());
        }
    }

    public class TennisGame
    {
        public string Score()
        {
            return String.Empty;
        }
    }
}
