using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_3_Classes
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

        public TimeSpan GetEpisodeLength()
        {
            return this.episodeLength;
        }

    }
}

