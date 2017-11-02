using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TennisKata
{
    public class TennisGame
    {
        public TennisGame()
        {
            player1Score = 0;
        }

        public string Score()
        {
            List<int> scoreMapping = new List<int>
            {
                0,
                15,
                30,
                40
            };
            return string.Format("{0}:0", scoreMapping[player1Score]);
        }

        public void Player1WinPoint()
        {
            player1Score++;
        }

        private int player1Score { get; set; }
    }
}