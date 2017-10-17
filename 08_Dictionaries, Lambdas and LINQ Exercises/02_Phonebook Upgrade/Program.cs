using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variant I w/o SortedDictionary
            //Dictionary<string, string> phonebook = new Dictionary<string, string>();

            //Variant II with SortedDictionary
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string[] commands = Console.ReadLine().Split(' ').ToArray();

            while (commands[0] != "END")
            {
                //string currKey = commands[1];

                if (commands[0] == "A")
                {
                    if (phonebook.ContainsKey(commands[1]))
                    {
                        phonebook[commands[1]] = commands[2];
                    }
                    else
                        phonebook.Add(commands[1], commands[2]);

                }
                else if (commands[0] == "S")
                {
                    if (phonebook.ContainsKey(commands[1]))
                    {
                        Console.WriteLine($"{commands[1]} -> {phonebook[commands[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {commands[1]} does not exist.");
                    }
                }
                else if (commands[0] == "ListAll")
                {
                    //Variant I w/o SortedDictionary
                    /*List<string> sortedKeys = new List<string>();
                    foreach (var keyValuePair in phonebook)
                        sortedKeys.Add(keyValuePair.Key);

                    sortedKeys.Sort();

                    foreach (var key in sortedKeys)
                        Console.WriteLine($"{key} -> {phonebook[key]}");
                    */

                    //Variant II with SortedDictionary
                    foreach (var keyValuePair in phonebook)
                        Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
