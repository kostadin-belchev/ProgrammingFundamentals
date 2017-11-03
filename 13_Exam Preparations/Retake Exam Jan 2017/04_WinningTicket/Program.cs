using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class WinningTicket
{
    static void Main()
    {
        //input
        List<string> listOfTickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        //program

        foreach (var ticket in listOfTickets)
        {
            if (ticket.Length != 20)
                Console.WriteLine("invalid ticket");
            else
            {
                string pattern = @"[$]{10}|[@]{10}|[#]{10}|[\^]{10}";
                string input = ticket;
                var matches = Regex.Matches(input, pattern);
                if (matches.Count > 0)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10$ Jackpot!");
                }
                else
                {
                    string pattern2 = @"[$]{6,9}|[@]{6,9}|[#]{6,9}|[\^]{6,9}";
                    string firstHalf = ticket.Take(5).ToString();
                    string secondHalf = ticket.Skip(5).Take(5).ToString();

                    foreach (Match mFirst in Regex.Matches(firstHalf, pattern2))
                    {
                        foreach (Match mSecond in Regex.Matches(secondHalf, pattern2))
                        {
                            if (mFirst == mSecond)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {mFirst.Length}$");
                            }
                            else
                                Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                    }
                }
            }
        }
    }
}

