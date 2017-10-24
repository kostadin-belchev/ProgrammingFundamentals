using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int lenghtOfShorterArr = Math.Min(arr1.Length, arr2.Length);

            if (arr1.Length > arr2.Length)
            {
                Console.WriteLine(arr2);
                Console.WriteLine(arr1);
            }
            else if (arr1.Length < arr2.Length)
            {
                Console.WriteLine(arr1);
                Console.WriteLine(arr2);
            }
            else if (arr1.Length == arr2.Length)
            {
                if (arr1[0] > arr2[0])
                {
                    Console.WriteLine(arr2);
                    Console.WriteLine(arr1);
                }
                else
                {
                    Console.WriteLine(arr1);
                    Console.WriteLine(arr2);
                }
            }
        }
    }
}
