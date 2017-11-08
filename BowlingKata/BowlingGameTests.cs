﻿using NUnit.Framework;

namespace BowlingKata
{
    [TestFixture]
    public class BowlingGameTests
    {
        [Test]
        public void InitScoreShouldBe0()
        {
            var game = new BowlingGame();

            Assert.AreEqual(0, game.Score(""));
        }

        [Test]
        public void All1PinScoreShouldBe10()
        {
            var game = new BowlingGame();

            Assert.AreEqual(10, game.Score("1- 1- 1- 1- 1- 1- 1- 1- 1- 1-"));
        }

    }
}