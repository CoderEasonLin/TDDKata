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

        [Test]
        public void Player2WinOnceShouldBe0vs15()
        {
            var game = new TennisGame();
            game.Player2WinBall();

            var expected = "0:15";

            Assert.AreEqual(expected, game.Score());
        }

        [Test]
        public void Player1WonOncePlayer2WinOnceShouldBe15vs15()
        {
            var game = new TennisGame();
            game.Player1WinBall();
            game.Player2WinBall();

            var expected = "15:15";

            Assert.AreEqual(expected, game.Score());
        }

        [Test]
        public void Player2WinForthShouldBePlayer2Win()
        {
            var game = new TennisGame();
            game.Player2WinBall();
            game.Player2WinBall();
            game.Player2WinBall();
            game.Player2WinBall();

            var expected = "Game Player2";

            Assert.AreEqual(expected, game.Score());
        }

    }
}
