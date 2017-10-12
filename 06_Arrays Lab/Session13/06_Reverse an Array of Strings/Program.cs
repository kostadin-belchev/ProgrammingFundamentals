using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfLittleString = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(arrayOfLittleString);

            for (int i = 0; i < arrayOfLittleString.Length; i++)
            {
                Console.Write(arrayOfLittleString[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
