using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Zad_4_Library
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
            using (StreamWriter file = new StreamWriter(NameOfFile))
            {
                file.WriteLine(words);
            }
        }
    }
}

