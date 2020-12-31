using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_4_Library
{
    public class Description
    {
        public int episodeNum { get; set; }
        public TimeSpan episodeLength { get; set; }
        public string episodeName { get; set; }


        public Description(int episodeNum, TimeSpan episodeLength, string episodeName)
        {
            this.episodeNum = episodeNum;
            this.episodeLength = episodeLength;
            this.episodeName = episodeName;
        }

        public Description(Description description)
        {
            this.episodeNum = description.episodeNum;
            this.episodeName = description.episodeName;
            this.episodeLength = description.episodeLength;
        }

        public TimeSpan GetEpisodeLength()
        {
            return this.episodeLength;
        }

    }
}