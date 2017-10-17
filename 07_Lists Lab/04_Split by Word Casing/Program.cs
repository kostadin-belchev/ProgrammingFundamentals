using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[]{ '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            foreach (string word in words)
            {
                var upperCaseCounter = 0;
                var lowerCaseCounter = 0;
                var mixedCaseCounter = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (Char.IsUpper(word[i]))
                        upperCaseCounter++;
                    else if (Char.IsLower(word[i]))
                        lowerCaseCounter++;
                    else
                        mixedCaseCounter++;
                }

                if (upperCaseCounter > 0 && lowerCaseCounter == 0 && mixedCaseCounter == 0)
                    upperCaseWords.Add(word);
                else if (lowerCaseCounter > 0 && upperCaseCounter == 0 && mixedCaseCounter == 0)
                    lowerCaseWords.Add(word);
                else
                    mixedCaseWords.Add(word);
                    
            }

            Console.Write("Lower-case: " + string.Join(", ", lowerCaseWords));
            Console.WriteLine();
            Console.Write("Mixed-case: " + string.Join(", ", mixedCaseWords));
            Console.WriteLine();
            Console.Write("Upper-case: " + string.Join(", ", upperCaseWords));
            Console.WriteLine();

            char test = '#';

            //Console.WriteLine(Char.IsLower(test));
        }
    }
}
