using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] placeholder = Console.ReadLine().Split("{}".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([A-Za-z]+)(.*)(\1)";
            // "." точката мачва абсолютно всичко. "+" мачва 1 път или повече. \1 копира условието от първата група, която е ([A-Za-z]+).

            var match = Regex.Matches(input, pattern);
            var count = 0;

            foreach (Match item in match)
            {
                string newString = item.Groups[1] + placeholder[count++] + item.Groups[3];
                input = input.Replace(item.Value, newString);               
            }
            Console.WriteLine(input);
        }
    }
}
