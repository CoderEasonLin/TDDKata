using NUnit.Framework;

namespace TennisKata
{
    [TestFixture]
    public class TennisGameTests
    {
        [TestCase(0, 0, "0:0")]
        [TestCase(1, 0, "15:0")]
        [TestCase(2, 0, "30:0")]
        [TestCase(3, 0, "40:0")]
        [TestCase(4, 0, "Game Player1")]
        [TestCase(0, 1, "0:15")]
        [TestCase(1, 1, "15:15")]
        [TestCase(0, 4, "Game Player2")]
        [TestCase(3, 3, "Deuce")]
        [TestCase(4, 3, "Advantage Player1")]
        [TestCase(3, 4, "Advantage Player2")]
        [TestCase(3, 5, "Game Player2")]
        public void TennisGameTest(int player1WinTimes, int player2WinTimes, string expected)
        {
            var game = new TennisGame();
            for(var i = 0; i < player1WinTimes; i++)
                game.Player1WinBall();

            for(var i = 0; i < player2WinTimes; i++)
                game.Player2WinBall();

            Assert.AreEqual(expected, game.Score());
        }
    }
}
