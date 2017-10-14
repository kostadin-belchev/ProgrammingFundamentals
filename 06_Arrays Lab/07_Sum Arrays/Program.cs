using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            

            int[] sumArray = new int[Math.Max(arr1.Length, arr2.Length)];

            if (arr1.Length >= arr2.Length)
            {
                for (int i = 0; i < sumArray.Length; i++)
                {
                    sumArray[i] = arr1[i] + arr2[i%arr2.Length];
                }

                for (int i = 0; i < sumArray.Length; i++)
                {
                    Console.Write(sumArray[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < sumArray.Length; i++)
                {
                    sumArray[i] = arr1[i%arr1.Length] + arr2[i];
                }

                for (int i = 0; i < sumArray.Length; i++)
                {
                    Console.Write(sumArray[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
