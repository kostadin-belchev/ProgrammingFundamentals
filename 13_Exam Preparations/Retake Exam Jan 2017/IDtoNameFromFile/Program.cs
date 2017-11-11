using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class IDtoNameFromFile
{
    static void Main()
    {
        List<string> inputLines = File.ReadAllLines("input.txt").ToList();

        Dictionary<string, string> iDsAndName = new Dictionary<string, string>();

        try
        {
            foreach (var line in inputLines)
            {
                var inputLineTokens = Regex.Split(line, " - ");

                var userID = inputLineTokens[0];
                var name = inputLineTokens[1];

                iDsAndName.Add(userID, name);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input file format. Please enter userIDs and name each on a single line separated by a dash with a space on either side of the dash. Example: kiro91 - Kiril Zlatinov");
        }
        

        Console.WriteLine("Enter userID to search for or \"exit\" to terminate program: ");
        
        try
        {
            var searchCommand = Console.ReadLine();

            while (true)
            {
                if (searchCommand == "exit")
                    break;

                var nameFound = string.Empty;
                bool isFound = false;

                foreach (var item in iDsAndName)
                {
                    if (searchCommand == item.Key)
                    {
                        nameFound = item.Value;
                        isFound = true;
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine("No matches found for this userID in the input.txt file.");
                    Console.WriteLine("Enter userID to search for or \"exit\" to terminate program: ");
                    searchCommand = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Match found for this userID in the input.txt file.");
                    Console.WriteLine(nameFound);
                    Console.WriteLine("Enter userID to search for or \"exit\" to terminate program: ");
                    searchCommand = Console.ReadLine();
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid search parameter, please enter a string for the userID or \"exit\" to terminate program.");
        }

    }
}

