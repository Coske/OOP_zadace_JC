using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Zad_4_Library
{
    public class Season : IEnumerable<Episode>
    {
        public int SeasonNum { get; private set; }
        public List<Episode> episodes { get; private set; }
        public int Length { get; private set; }

        public Season(int SeasonNum, List<Episode> episodes)
        {
            this.SeasonNum = SeasonNum;
            this.episodes = episodes;
            Length = episodes.Count;
        }

        public Season(Season season)
        {
            this.episodes = new List<Episode>();
            foreach(var episode in season)
            {
                episodes.Add(new Episode(episode));
            }
            this.SeasonNum = season.SeasonNum;
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

        public void AddEpisode(Episode episode)
        {
            episodes.Add(episode);
        }

        public void Remove(string NameOfEpisode)
        {
            
            for(int i = 0;i<episodes.Count;i++)
            {
                if (NameOfEpisode == episodes[i].GetDescription().episodeName)
                {
                    episodes.RemoveAt(i);
                    return;
                }
  
            }
            throw new TvException(NameOfEpisode, "No such episode found");
        }

        public IEnumerator<Episode> GetEnumerator()
        {
            return ((IEnumerable<Episode>)episodes).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Episode>)episodes).GetEnumerator();
        }
    }
}
