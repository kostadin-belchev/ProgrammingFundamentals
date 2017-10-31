using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([^0-9]+)(\d+)";
            string input = Console.ReadLine();

            StringBuilder rageMessage = new StringBuilder();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                var word = m.Groups[1].Value.ToUpper();
                var count = int.Parse(m.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    rageMessage.Append(word);
                }
            }

            int uniqueSymbols = rageMessage.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(rageMessage);
        }
    }
}
