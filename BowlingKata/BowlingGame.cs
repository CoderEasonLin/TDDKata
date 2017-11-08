using System;

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

            _frames = ToFrames(frameResult);

            var frames = frameResult.Split(' ');
            for (int i = 0; i < frames.Length; i++)
            {
                var frame = frames[i];
                foreach (var token in frame)
                {
                    if (token == '-')
                        continue;

                    score += Convert.ToInt32(token.ToString());
                }
            }

            return score;
        }

        private string[] ToFrames(string frameResult)
        {
            return frameResult.Split(' ');
        }
    }
}
