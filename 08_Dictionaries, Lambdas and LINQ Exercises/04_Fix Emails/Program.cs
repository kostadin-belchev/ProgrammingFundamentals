using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> listOfNamesAndEmails = new Dictionary<string, string>();
            Dictionary<string, string> resultsOfNamesAndEmails = new Dictionary<string, string>();

            string oddLine = Console.ReadLine();

            while (oddLine != "stop")
            {
                if (oddLine == "stop")
                    break;
                else //if (listOfNamesAndEmails.Keys.Contains(oddLine))
                {
                    string keyToAdd = oddLine;
                    string valueToAdd = Console.ReadLine();
                    listOfNamesAndEmails.Add(keyToAdd, valueToAdd);
                }
                oddLine = Console.ReadLine();
            }

            foreach (var keyValuePair in listOfNamesAndEmails)
            {

                List<string> sumElementsOfEachValue = keyValuePair.Value.Split('.').ToList();
                if (sumElementsOfEachValue.Last().ToLower() != "us" && sumElementsOfEachValue.Last().ToLower() != "uk")
                {
                    resultsOfNamesAndEmails.Add(keyValuePair.Key, keyValuePair.Value);
                }
                
            }
            foreach (var keyValuePair in resultsOfNamesAndEmails)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
            
        }
    }
}
