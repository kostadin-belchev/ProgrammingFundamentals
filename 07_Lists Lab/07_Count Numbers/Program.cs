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
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(nums);

            //Test if sorted correctly
            //Console.WriteLine(string.Join(" ", nums));

            for (int i = 1; i <= nums.Length; i++)
            {
                var counter = 1;
                if (nums[i - 1] == nums[i])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{nums[i]} -> {counter}");
                }
            }
        }
    }
}
