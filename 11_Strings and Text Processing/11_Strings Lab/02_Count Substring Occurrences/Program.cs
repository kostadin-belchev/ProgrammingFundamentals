using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int counter = 0;
            int foundAtIndex = text.IndexOf(pattern);

            while (foundAtIndex != -1)
            {
                counter++;
                foundAtIndex = text.IndexOf(pattern, foundAtIndex + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
