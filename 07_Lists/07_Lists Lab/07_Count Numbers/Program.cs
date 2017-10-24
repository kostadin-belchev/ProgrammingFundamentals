using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Algorithm 1: Sort the numbers and count occurrences of each number.
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            // 8 2 2 8 2 2 3 7
            nums.Sort();

            //Test if sorted correctly {2, 2, 2, 2, 3, 7, 8, 8}.
            //Console.WriteLine(string.Join(" ", nums));
            int[] counterArray= new int[1001];

            for (int i = 0; i < nums.Count; i++)
            {
                counterArray[nums[i]]++;
            }
            for (int i = 0; i < counterArray.Length; i++)
            {
                if (counterArray[i] != 0)
                {
                    Console.WriteLine($"{i} -> {counterArray[i]}");
                }
            }
        }
    }
}
