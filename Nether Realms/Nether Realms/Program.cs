using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> demonNames = Console.ReadLine().Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).OrderBy(a => a)
                .ToList();

            var regexHP = @"[^\d\+\-\*\/\*\.]";
            var regexDMG = @"[-+]?\d+(?:\.\d+)?";

            foreach (var demon in demonNames)
            {
                var health = 0;
                Regex hp = new Regex(regexHP);
                var sumHealth = hp.Matches(demon);
                foreach (Match item in sumHealth)
                {
                    health += (char)item.Value[0];
                }

                double damage = 0;
                Regex dmg = new Regex(regexDMG);
                var sumDMG = dmg.Matches(demon);
                foreach (Match items in sumDMG)
                {
                    damage += double.Parse(items.Value);
                }

                var multi = demon.Where(a => a == '*');
                damage *= Math.Pow(2, multi.Count());
                var divite = demon.Where(c => c == '/');
                damage /= Math.Pow(2, divite.Count());

                Console.WriteLine($"{demon} - {health} health, {damage:f2} damage");
            }
        }
    }
}
