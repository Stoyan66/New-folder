using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^(<\[[^A-Za-z0-9\n]*]\.)(\.\[[A-Za-z0-9]*]\.)*$";
            // Знакът "^" значи всичко различно от посоченото след него. Знакът "*" значи, че може да го има 0 или повече пъти.
            // Знакът "^" и "$" служат, за да се покаже началото и краят на стринга.
            // Полза се multiline в Regex101
            // \n - нов ред.

            while (input != "Traincode!")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
