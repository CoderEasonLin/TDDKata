using System;

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
            return string.Format("{0}:0", player1Score);
        }

        public void Player1WinPoint()
        {
            player1Score += 15;
        }

        private int player1Score { get; set; }
    }
}