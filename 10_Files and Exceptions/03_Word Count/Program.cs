using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("input.txt").ToLower();
            string[] words = text.Split(new char[] {'\n','\r',' ', '.', ',', '!', '?', '-'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
                else
                {
                    wordsCount[word] = 1;
                }
            }

            List<KeyValuePair<string, int>> result = wordsCount.OrderByDescending(keyValuePair => keyValuePair.Value).ToList();

            List<string> resultLines = result.Select(keyValuePair => $"{keyValuePair.Key} -> {keyValuePair.Value}").ToList();

            File.WriteAllLines("results.txt", resultLines);

        }
    }
}
