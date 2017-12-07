using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"^([^\s_]{3})(\.[^\s_]{3})*$";

            while (input != "ReadMe")
            {
                var inputMatch = Regex.Match(input, pattern);
                if (inputMatch.Success)
                {
                    if (Palindrome(input))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                else
                {
                    Console.WriteLine("NO");
                }

                input = Console.ReadLine();
            }
        }
        static bool Palindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length -1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
