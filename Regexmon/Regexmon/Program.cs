using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string didimonPattern = @"([^A-Za-z-]+)";
            string bojoPattern = @"([A-Za-z]+\-[A-Za-z]+)";

            while (true)
            {
                var didimonMatch = Regex.Match(input, didimonPattern);


                if (didimonMatch.Success)
                {
                    Console.WriteLine(didimonMatch.Value);
                    input = input.Substring(input.IndexOf(didimonMatch.Value) + didimonMatch.Value.Length);
                }
                else
                {
                    break;
                }

                var bojoMatch = Regex.Match(input, bojoPattern);

                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value);
                    input = input.Substring(input.IndexOf(bojoMatch.Value) + bojoMatch.Value.Length);
                }
                else
                {
                    break;
                }
            }

        }
    }
}


