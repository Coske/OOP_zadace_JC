using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_4_Library
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string words)
        {
            Console.WriteLine(words);
        }
    }
}


