using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TennisKata
{
    public class TennisGame
    {
        private int player1Score { get; set; }
        private bool player1Won;
        private const int MAX_POINT_PER_GAME = 4;

        public string Score()
        {
            List<int> scoreMapping = new List<int>
            {
                0,
                15,
                30,
                40
            };

            if (player1Won)
                return "Game Player1";
            return string.Format("{0}:0", scoreMapping[player1Score]);
        }

        public void Player1WinBall()
        {
            player1Score++;
            if (player1Score == MAX_POINT_PER_GAME)
            {
                player1Won = true;
            }
        }

    }
}