using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfInts = new int[n];

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                arrayOfInts[i] = int.Parse(Console.ReadLine());
            }

            //int[] reversedArrayOfInts = new int[n];

            for (int i = arrayOfInts.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayOfInts[i] + " ");
            }

        }
    }
}
