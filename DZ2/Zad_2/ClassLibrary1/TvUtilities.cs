﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ClassLibrary
{
    public class TvUtilities
    {
        public static double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * 10;
        }




        public static void Sort(Episode[] episodes)
        {
            int max;
            for (int i = 0; i < episodes.Length - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < episodes.Length; j++)
                {
                    if (episodes[j] > episodes[max])
                    {
                        max = j;
                    }
                }

                if (max != i)
                {
                    Episode temp = episodes[i];
                    episodes[i] = episodes[max];
                    episodes[max] = temp;
                }

            }

        }

        public static Episode Parse(string x)
        {
            string[] parts = x.Split(',');

            Description description = new Description(int.Parse(parts[3]), TimeSpan.Parse(parts[4]), parts[5]);
            return new Episode(int.Parse(parts[0]), Double.Parse(parts[1]), Double.Parse(parts[2]), description);

        }
    }
}
