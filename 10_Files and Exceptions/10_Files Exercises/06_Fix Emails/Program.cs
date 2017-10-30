using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");
            var indexer = 0;
            string name = input[indexer++];

            var emails = new Dictionary<string, string>();

            while (name != "stop")
            {
                var email = input[indexer++];

                if (!email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    emails[name] = email;
                }
                name = input[indexer++];
            }

            var emailsOutput = new List<string>();

            foreach (var person in emails)
            {
                emailsOutput.Add($"{person.Key} -> {person.Value}");
            }

            File.WriteAllLines("output.txt", emailsOutput);
        }
    }
}
