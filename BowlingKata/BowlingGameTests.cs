using NUnit.Framework;

namespace BowlingKata
{
    [TestFixture]
    public class BowlingGameTests
    {
        [TestCase("", 0)]
        [TestCase("1- 1- 1- 1- 1- 1- 1- 1- 1- 1-", 10)]
        public void InitScoreShouldBe0(string rollResult, int expectedScore)
        {
            var game = new BowlingGame();

            Assert.AreEqual(expectedScore, game.Score(rollResult));
        }
    }
}