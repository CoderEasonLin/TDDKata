﻿using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TennisKata
{
    public class TennisGame
    {
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

        public void Player1WinBall()
        {
            player1Score++;
        }

        private int player1Score { get; set; }
    }
}