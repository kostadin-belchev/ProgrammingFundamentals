using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> results = new List<string>();

            List<string> tokens = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            tokens.Reverse();
            
            foreach (var token in tokens)
            {
                List<string> setOfNums = token.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                results.AddRange(setOfNums);
            }
            
            Console.Write(string.Join(" ", results));

            Console.WriteLine();
        }
    }
}
