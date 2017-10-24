using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine(ReverseNumber(number));
        }

        private static decimal ReverseNumber(decimal number)
        {
            decimal d = number;
            string s = d.ToString();
            string reversedString = ReverseString(s);
            decimal reversedDecimal = Convert.ToDecimal(reversedString);
            return reversedDecimal;
        }

        private static string ReverseString(string stringToReverse)
        {
            char[] charArray = stringToReverse.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
            
        }
    }
}
