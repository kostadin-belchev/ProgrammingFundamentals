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
            Dictionary<string, int> listOfNamesAndEmails = new Dictionary<string, int>();

            do
            {
                listOfNamesAndEmails.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));

            } while (listOfNamesAndEmails.Last().Key == "stop");
        }
    }
}
