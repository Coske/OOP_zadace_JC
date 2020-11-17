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

        public Episode(int viewers, double scoresum, double scoremax, Description description)
        {
            Viewers = viewers;
            ScoreSum = scoresum;
            ScoreMax = scoremax;
            this.description = description;
        }
        public Description description { get; set; }
        public double ScoreSum { get; set; }
        public double ScoreMax { get; set; }


        public double GetMaxScore()
        {
            return ScoreMax;
        }

        public double GetAverageScore()
        {
            return ScoreSum / Viewers;
            //return ScoreAverage;
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
            return $"{Viewers},{ScoreSum},{ScoreMax},{this.description.episodeNum},{this.description.episodeLength},{this.description.episodeName}";
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

