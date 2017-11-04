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
                    Console.WriteLine($"ticket \"{ticket}\" - 10{matches[0].Value.First()} Jackpot!");
                }
                else //the code below sould not ne in a else, maybe a if else....
                {
                    string pattern2 = @"[$]{6,9}|[@]{6,9}|[#]{6,9}|[\^]{6,9}";
                    string firstHalf = ticket.Substring(0, 10);
                    string secondHalf = ticket.Substring(10); // or ticket.Substring(10, 20);
                    var matches2 = Regex.Matches(firstHalf, pattern2);
                    var matches3 = Regex.Matches(secondHalf, pattern2);

                    if (matches2.Count > 0 && matches3.Count > 0)
                    {
                        if (matches2[0].Value == matches3[0].Value && firstHalf.Length <= secondHalf.Length)
                            Console.WriteLine($"ticket \"{ticket}\" - {matches2[0].Length}{matches2[0].Value.First()}");
                        else if (matches2[0].Value == matches3[0].Value && firstHalf.Length > secondHalf.Length)
                            Console.WriteLine($"ticket \"{ticket}\" - {matches3[0].Length}{matches3[0].Value.First()}");
                    }
                    else
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}

