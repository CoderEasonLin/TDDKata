using System;
using System.Linq;

namespace BowlingKata
{
    public class BowlingGame
    {
        private string[] _frames;

        public int Score(string frameResult)
        {
            var score = 0;
            if(string.IsNullOrEmpty(frameResult))
                return score;

            var frames = frameResult.Split(' ');
            for (int i = 0; i < frames.Length; i++)
            {
                var frame = frames[i];
                if (frame.IndexOf("/") == 1)
                {
                    score += 10;

                    var nextFrame = frames[i + 1];
                    if (nextFrame[0] == '-')
                        continue;
                    score += Convert.ToInt32(nextFrame[0].ToString());
                }
                else
                {
                    foreach (var token in frame)
                    {
                        if (token == '-')
                            continue;

                        score += Convert.ToInt32(token.ToString());
                    }
                }
            }

            return score;
        }
    }
}
