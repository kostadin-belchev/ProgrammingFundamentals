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

            int len1 = arr1.Length;
            int len2 = arr2.Length;

            int[] sumArray = new int[Math.Max(len1, len2)];

            

            if (arr1.Length > arr2.Length)
            {
                for (int i = 0; i < len1; i++)
                {
                    sumArray[i] = arr1[i] + arr2[i%len2];
                }
            }
            else if (arr1.Length < arr2.Length)
            {
                for (int i = 0; i < len2; i++)
                {
                    sumArray[i] = arr1[i%len1] + arr2[i];
                }
            }
            else
                for (int i = 0; i < len1; i++)
                    sumArray[i] = arr1[i] + arr2[i];

            for (int i = 0; i < sumArray.Length; i++)
            {
                Console.Write(sumArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
//Solution:
/*if (arr1.Length >= arr2.Length)
            {
                for (int i = 0; i<sumArray.Length; i++)
                {
                    sumArray[i] = arr1[i] + arr2[i % arr2.Length];
                }

                for (int i = 0; i<sumArray.Length; i++)
                {
                    Console.Write(sumArray[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i<sumArray.Length; i++)
                {
                    sumArray[i] = arr1[i % arr1.Length] + arr2[i];
                }

                for (int i = 0; i<sumArray.Length; i++)
                {
                    Console.Write(sumArray[i] + " ");
                }
                Console.WriteLine();
            }
            */