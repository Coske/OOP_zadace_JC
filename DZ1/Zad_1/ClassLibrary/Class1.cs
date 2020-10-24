using System;

namespace ClassLibrary
{
    public class Episode
    {
        public int Viewers = 0;

        public Episode()
        {
            ScoreSum = 0;
            ScoreMax = 0;

        }

        public Episode(int viewers, double scoresum, double scoremax)
        {
            Viewers = viewers;
            ScoreSum = scoresum;
            ScoreMax = scoremax;
        }

        public double ScoreSum { get; set; }
        public double ScoreMax { get; set; }


        public double GetMaxScore()
        {
            return ScoreMax;
        }


        public double GetAverageScore()
        {
            return ScoreSum / Viewers;
        }


        public void AddView(double ScoreCurrent)
        {
            Viewers++;
            ScoreSum += ScoreCurrent;
            if (ScoreCurrent > ScoreMax)
            {
                ScoreMax = ScoreCurrent;
            }
        }

        public int GetViewerCount()
        {
            return Viewers;
        }
    }
}

