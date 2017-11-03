using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using NUnit.Framework;

namespace TennisKata
{
    public class TennisGame
    {
        private int player1Score { get; set; }
        private bool player1Won;

        private int player2Score;
        private bool player2Won;
        private bool deuce;

        private readonly List<int> _scoreMapping = new List<int>
        {
            0,
            15,
            30,
            40
        };

        private const int MAX_POINT_PER_GAME = 4;

        public string Score()
        {
            if (deuce)
                return "Deuce";
            if (player1Won)
                return "Game Player1";
            if (player2Won)
                return "Game Player2";

            return string.Format("{0}:{1}", _scoreMapping[player1Score], _scoreMapping[player2Score]);
        }

        public void Player1WinBall()
        {
            player1Score++;
            if (player1Score >= MAX_POINT_PER_GAME)
            {
                if (player2Score >= MAX_POINT_PER_GAME)
                    deuce = true;
                else
                    player1Won = true;
            }
        }

        public void Player2WinBall()
        {
            player2Score++;
            if (player2Score == MAX_POINT_PER_GAME)
            {
                if (player1Score >= MAX_POINT_PER_GAME)
                    deuce = true;
                else
                    player2Won = true;
            }
        }
    }
}