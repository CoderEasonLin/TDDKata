using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TennisKata
{
    [TestFixture]
    public class TennisGameTests
    {
        [Test]
        public void GameStartScoreShouldBe0vs0()
        {
            var game = new TennisGame();

            var expected = "0:0";

            Assert.AreEqual(expected, game.Score());
        }

        [Test]
        public void Player1WinOnceShouldBe15vs0()
        {
            var game = new TennisGame();
            game.Player1WinBall();
            var expected = "15:0";

            Assert.AreEqual(expected, game.Score());
        }

        [Test]
        public void Player1WinTwiceShouldBe30vs0()
        {
            var game = new TennisGame();
            game.Player1WinBall();
            game.Player1WinBall();

            var expected = "30:0";

            Assert.AreEqual(expected, game.Score());
        }

        [Test]
        public void Player1WinThirdShouldBe40vs0()
        {
            var game = new TennisGame();
            game.Player1WinBall();
            game.Player1WinBall();
            game.Player1WinBall();

            var expected = "40:0";

            Assert.AreEqual(expected, game.Score());
        }

        [Test]
        public void Player1WinForthShouldBePlayer1Win()
        {
            var game = new TennisGame();
            game.Player1WinBall();
            game.Player1WinBall();
            game.Player1WinBall();
            game.Player1WinBall();

            var expected = "Game Player1";

            Assert.AreEqual(expected, game.Score());
        }
    }
}
