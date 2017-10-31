using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var charArray = input.ToCharArray();
            
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write($"\\u{(int)charArray[i]:X4}".ToLower());
            }
            Console.WriteLine();
        }
    }
}
