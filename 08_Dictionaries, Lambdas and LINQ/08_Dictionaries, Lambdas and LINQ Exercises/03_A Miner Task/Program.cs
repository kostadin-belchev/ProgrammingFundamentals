using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();

            string oddLine = Console.ReadLine();
            string valueToAdd = "";
            string evenLine = "";
            string currValue = "";

            while (oddLine != "stop")
            {
                string keyToAdd = "";
                if (oddLine == "stop")
                    break;
                else if(!list.Keys.Contains(oddLine))
                {
                    keyToAdd = oddLine;
                    evenLine = Console.ReadLine();
                    valueToAdd = evenLine;
                    list.Add(keyToAdd, valueToAdd);
                }
                else if (list.Keys.Contains(oddLine))
                {
                    evenLine = Console.ReadLine();
                    list.TryGetValue(oddLine, out currValue);
                    long sum = long.Parse(evenLine) + long.Parse(currValue);
                    list[oddLine] = sum.ToString();
                }
                oddLine = Console.ReadLine();
            }
            
            foreach (var keyValuePair in list)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }
    }
}
/*
 * string firstInputLine = Console.ReadLine();
            string secondInputLine = "";

            Dictionary<string, string> list = new Dictionary<string, string>();

            while (firstInputLine != "stop")
            {
                string keyToBeAdded = "";
                string valueToBeAdded = "";

                if (firstInputLine != "stop")
                {
                    keyToBeAdded = firstInputLine;
                    secondInputLine = Console.ReadLine();
                    valueToBeAdded = secondInputLine;
                    if (list.ContainsKey(keyToBeAdded))
                    {
                        list[keyToBeAdded] += valueToBeAdded;
                    }
                    else
                        list.Add(keyToBeAdded, valueToBeAdded);
                }
                
                firstInputLine = Console.ReadLine();
            }

            foreach (var keyValuePair in list)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
 */
