using System;

namespace BowlingKata
{
    public class BowlingGame
    {
        public int Score(string frameResult)
        {
            if(string.IsNullOrEmpty(frameResult))
                return 0;

            var score = 0;
            foreach (var token in frameResult)
            {
                if (token == '-' || token == ' ')
                    continue;
                score += Convert.ToInt32(token.ToString());
            }

            return score;
        }
    }
}
