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
    }
}
