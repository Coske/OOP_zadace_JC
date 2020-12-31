using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Zad_4_Library
{

    public class TvException : Exception
    {

        public string Title { get; private set; }

        public TvException() { }
        public TvException(string title, string message) : base(message) 
        {
            Title = title;
        }


    }
}