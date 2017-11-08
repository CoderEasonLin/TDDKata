using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Api;

namespace BowlingKata
{
    public class BowlingGame
    {
        private List<Frame> _frames;

        public int Score(string frameResult)
        {
            var score = 0;
            if(string.IsNullOrEmpty(frameResult))
                return score;

            ToFrames(frameResult);

            for (var i = 0; i < 10; i++)
            {
                var frame = _frames[i];
                score += frame.Score;

                if (frame.IsSpare)
                    score += _frames[i + 1].ScoreOfFirstRoll;

                if (frame.IsStrike)
                {
                    if (_frames[i + 1].IsStrike)
                    {
                        score += _frames[i + 1].Score;
                        score += _frames[i + 2].ScoreOfFirstRoll;
                    }
                    else
                    {
                        score += _frames[i + 1].Score;
                    }
                }
            }

            return score;
        }

        private void ToFrames(string frameResult)
        {
            var frames = frameResult.Split(' ');
            _frames = new List<Frame>();
            foreach (var frame in frames)
            {
                _frames.Add(new Frame(frame));
            }
        }
    }

    public class Frame
    {
        private readonly string _frame;

        public Frame(string frame)
        {
            _frame = frame;
        }

        public int Score
        {
            get
            {
                if (IsSpare || IsStrike)
                    return 10;

                var score = 0;
                foreach (var roll in _frame)
                {
                    score += ScoreOf(roll);
                }
                return score;
            }
        }

        private static int ScoreOf(char token)
        {
            if (token == '-')
                return 0;

            if (token == 'X')
                return 10;

            return Convert.ToInt32(token.ToString());
        }

        public bool IsSpare
        {
            get { return _frame.IndexOf("/") == 1; }
        }

        public int ScoreOfFirstRoll
        {
            get { return ScoreOf(_frame[0]); }
        }

        public bool IsStrike {
            get { return _frame.IndexOf("X") == 0; } }
    }
}
