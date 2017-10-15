using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] rotatedArr = new int[arr.Length];
            int[] sum = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                rotatedArr[(i + k) % arr.Length]  = arr[i];
            }
        }
    }
}
