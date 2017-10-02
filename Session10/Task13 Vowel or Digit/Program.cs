using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();


            if (symbol == "a" || symbol == "e" || symbol == "i" || symbol == "o" || symbol == "u")
            {
                Console.WriteLine("vowel");
            }
            else if (symbol.Contains("0") || symbol.Contains("1") || symbol.Contains("2") || symbol.Contains("3") || symbol.Contains("3") || symbol.Contains("4") || symbol.Contains("5") || symbol.Contains("6") || symbol.Contains("7") || symbol.Contains("8") || symbol.Contains("9"))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
