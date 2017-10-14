using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new[] { ' ' }
            ,StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (nums.Length > 1)
            {
                int[] condensed = new int[nums.Length - 1];
                for (int i = 1; i < nums.Length; i++)
                {
                    condensed[i - 1] = nums[i - 1] + nums[i];
                }
                nums = condensed;
                //nums.Take(nums.Length - 1);
            }
                
            

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
