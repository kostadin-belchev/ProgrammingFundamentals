using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(File.ReadAllText("numberOfMessages.txt"));

            string[] phrases = File.ReadAllText("phrases.txt").Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);
            string[] events = File.ReadAllText("events.txt").Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);
            string[] authors = File.ReadAllText("authors.txt").Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);
            string[] cities = File.ReadAllText("cities.txt").Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);

            Random random = new Random();

            List<string> output = new List<string>();

            for (int i = 0; i < n; i++)
            {
                int phraseIndex = random.Next(0, phrases.Length);
                int eventsIndex = random.Next(0, events.Length);
                int authorIndex = random.Next(0, authors.Length);
                int townIndex = random.Next(0, cities.Length);

                output.Add($"{phrases[phraseIndex]} {events[eventsIndex]} {authors[authorIndex]} - {cities[townIndex]}.");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
