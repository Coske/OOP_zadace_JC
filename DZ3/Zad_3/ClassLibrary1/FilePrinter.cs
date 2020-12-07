using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibrary
{
    public class FilePrinter : IPrinter
    {
        public string NameOfFile { get; set; }

        public FilePrinter(string NameOfFile)
        {
            this.NameOfFile = NameOfFile;
        }
        public void Print(string words)
        {
            using(StreamWriter file = new StreamWriter(NameOfFile))
            {
                file.WriteLine(words);
            }
        }
    }
}
