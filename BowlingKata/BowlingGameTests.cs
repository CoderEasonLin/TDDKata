using NUnit.Framework;

namespace BowlingKata
{
    [TestFixture]
    public class BowlingGameTests
    {
        [TestCase("", 0)]
        [TestCase("1- 1- 1- 1- 1- 1- 1- 1- 1- 1-", 10)]
        [TestCase("15 1- 1- 1- 1- 1- 1- 1- 1- 1-", 15)]
        [TestCase("15 1- 1- 1- 18 1- 1- 1- 1- 1-", 23)]
        [TestCase("15 1- 1/ 1- 18 1- 1- 1- 1- 1-", 33)]
        [TestCase("15 1- 1/ 1- 18 1/ 1- 1- 1- 1-", 43)]
        [TestCase("15 1- 1/ 1/ 18 1/ 1- 1- 1- 1-", 53)]
        [TestCase("15 1- 1/ 1/ 18 1/ 1- 1- 1- 1/ 1", 64)]
        [TestCase("15 1- 1/ 1/ 18 X 1- 1- 1- 1/ 1", 64)]
        [TestCase("15 1- 1/ 1/ 18 X X 1- 1- 1/ 1", 84)]
        [TestCase("15 1- 1/ 1/ 18 X X 1- 1- X 1/", 93)]
        public void BowlingGameTest(string rollResult, int expectedScore)
        {
            var game = new BowlingGame();

            Assert.AreEqual(expectedScore, game.Score(rollResult));
        }
    }
}