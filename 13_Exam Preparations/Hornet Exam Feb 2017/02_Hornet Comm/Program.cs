using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02_Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> inputLines = new List<string>();

            while (input != "Hornet is Green")
            {
                if (input == "Hornet is Green")
                    break;
                else
                {
                    inputLines.Add(input);
                }
                input = Console.ReadLine();
            }
            //Console.WriteLine(string.Join(", ", inputLines));

            Dictionary<string, string> firstQAndSecondQ = new Dictionary<string, string>();

            foreach (var line in inputLines)
            {
                string[] elementsOfLine = Regex.Split(line, " <-> ");
                var keyToAdd = elementsOfLine[0];
                var valueToAdd = elementsOfLine[1];

                if (!firstQAndSecondQ.ContainsKey(keyToAdd))
                    firstQAndSecondQ.Add(keyToAdd, valueToAdd);
            }

            //bool isDigit = 
            
        }
    }
}
