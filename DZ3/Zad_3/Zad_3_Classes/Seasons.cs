using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_3_Classes
{
    public class Season
    {
        public int SeasonNum { get; private set; }
        public Episode[] episodes { get; private set; }
        public int Length { get; private set; }

        public Season(int SeasonNum, Episode[] episodes)
        {
            this.SeasonNum = SeasonNum;
            this.episodes = episodes;
            Length = episodes.Length;
        }

        public Episode this[int i]
        {
            get { return this.episodes[i]; }
            set { this.episodes[i] = value; }
        }
        public int getTotalViews()
        {
            int totalViews = 0;
            foreach (Episode episode in episodes)
            {
                totalViews += episode.GetViewerCount();
            }
            return totalViews;
        }

        public TimeSpan getTotalEpisodeLength()
        {
            TimeSpan TotalEpisodeLength = new TimeSpan(0, 0, 0);
            foreach (Episode episode in episodes)
            {
                TotalEpisodeLength += episode.GetDescription().GetEpisodeLength();
            }
            return TotalEpisodeLength;
        }

        public override string ToString()
        {
            string ReturningText = "";
            ReturningText += $"Seasons {SeasonNum}:\n" +
                "=================================================\n";

            foreach (Episode episode in episodes)
            {
                ReturningText += $"{episode.ToString()}\n";
            }
            ReturningText += "Report:\n" +
                "=================================================\n" +
                $"Total viewers: {getTotalViews()}\n" +
                $"Total duration: {getTotalEpisodeLength()}\n" +
                "=================================================";

            return $"{ReturningText}";
        }
    }
}

