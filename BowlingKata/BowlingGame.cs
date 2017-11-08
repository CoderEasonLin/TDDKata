using NUnit.Framework;

namespace BowlingKata
{
    public class BowlingGame
    {
        public int Score()
        {
            return 0;
        }
    }

    [TestFixture]
    public class BowlingGameTests
    {
        [Test]
        public void InitScoreShouldBe0()
        {
            var game = new BowlingGame();

            Assert.AreEqual(0, game.Score());
        }

    }

}
