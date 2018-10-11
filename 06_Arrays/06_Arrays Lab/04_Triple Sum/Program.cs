using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(element => int.Parse(element)).ToArray();

            bool tripletExists = false;
            //Console.WriteLine($"{a} + {b} == {a + b}");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr.Contains(arr[i] + arr[j]))
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[i] + arr[j]}");
                        tripletExists = true;
                    }
                }
            }
            if (!tripletExists)
            {
                Console.WriteLine("No");
            }
        }
    }
}
