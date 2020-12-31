using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_4_Library
{
    public class Episode
    {
        private int Viewers = 0;

        public Episode()
        {
            ScoreSum = 0;
            ScoreMax = 0;

        }

        public Episode(int viewers, double scoresum, double scoremax, Description description)
        {
            Viewers = viewers;
            ScoreSum = scoresum;
            ScoreMax = scoremax;
            this.description = description;
        }
        private Description description { get; set; }
        private double ScoreSum { get; set; }
        private double ScoreMax { get; set; }

        public Episode(Episode episode)
        {
            this.Viewers = episode.Viewers;
            this.ScoreSum = episode.ScoreSum;
            this.ScoreMax = episode.ScoreMax;
            this.description = new Description(episode.description);
        }

        public double GetMaxScore()
        {
            return ScoreMax;
        }
        public double GetScoreSum()
        {
            return ScoreSum;
        }

        public double GetAverageScore()
        {
            return ScoreSum / Viewers;

        }

        public Description GetDescription()
        {
            return this.description;
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
        public override string ToString()
        {
            return $"{Viewers},{Math.Round(ScoreSum, 4)},{ScoreMax},{this.description.episodeNum},{this.description.episodeLength},{this.description.episodeName}";
        }

        public static bool operator <(Episode episode1, Episode episode2)
        {
            return (episode1.ScoreSum) < (episode2.ScoreSum);
        }
        public static bool operator >(Episode episode1, Episode episode2)
        {
            return !(episode1 < episode2);
        }
    }
}

