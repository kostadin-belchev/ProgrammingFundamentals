using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> words = input.Split(' ').ToList();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word.ToLower()))
                    counts[word.ToLower()]++;
                else
                    counts[word.ToLower()] = 1;
            }

            List<string> results = new List<string>();

            foreach (var keyValuePair in counts)
            {
                if (keyValuePair.Value % 2 != 0)
                    results.Add(keyValuePair.Key);
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
