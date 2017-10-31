using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string string1 = input[0];
            string string2 = input[1];

            HashSet<char> firstSet = new HashSet<char>(string1.ToCharArray());
            HashSet<char> secondSet = new HashSet<char>(string2.ToCharArray());
            
            Console.WriteLine(IsExchangable(firstSet, secondSet).ToString().ToLower());
            //firstSet.Count != secondSet.Count ? "false" : "true"
        }

        private static bool IsExchangable(HashSet<char> firstSet, HashSet<char> secondSet)
        {
            if (firstSet.Count != secondSet.Count)
                return false;
            else
                return true;
        }
    }
}
