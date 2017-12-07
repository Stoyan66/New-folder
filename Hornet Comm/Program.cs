using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string privateMessagePattern = @"^([0-9]+) <-> ([A-Za-z0-9]*)$";
            string broadcastPattern = @"^([^0-9]+) <-> ([A-Za-z0-9]*)$";

            List<string> messages = new List<string>();
            List<string> broadcast = new List<string>();

            while (input != "Hornet is Green")
            {

                var privateMessageMatch = Regex.Match(input, privateMessagePattern);
                var broadcastmatch = Regex.Match(input, broadcastPattern);

                if (privateMessageMatch.Success)
                {
                    string recepientcode = privateMessageMatch.Groups[1].ToString();
                    recepientcode = string.Join("", recepientcode.ToCharArray().Reverse().ToArray());

                    messages.Add(recepientcode + " -> " + privateMessageMatch.Groups[2].ToString());
                }
                if (broadcastmatch.Success)
                {
                    string frequency = broadcastmatch.Groups[2].ToString();
                    string frequencyResult = "";

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (Char.IsLower(frequency[i]))
                        {
                            frequencyResult += frequency[i].ToString().ToUpper();
                        }
                        else if (Char.IsUpper(frequency[i]))
                        {
                            frequencyResult += frequency[i].ToString().ToLower();
                        }
                        else
                        {
                            frequencyResult += frequency[i].ToString();
                        }
                                               
                    }
                    broadcast.Add(frequencyResult + " -> " + broadcastmatch.Groups[1]);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < broadcast.Count; i++)
                {
                    Console.WriteLine(broadcast[i]);
                    //broadcast.ForEach(e => Console.WriteLine(e)); Може и да се принтира така без for цикъл!
                }
            }
            Console.WriteLine("Messages:");

            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < messages.Count; i++)
                {
                    Console.WriteLine(messages[i]);
                    //messages.ForEach(e => Console.WriteLine(e));
                }
            }
        }
    }
}
