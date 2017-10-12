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
            int[] nums = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int finalResult = 0;

            for (int j = 0; j < nums.Length - 1; j++)
            {
                int[] condensed = new int[nums.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                nums = condensed;
                //Array.Resize(ref nums, nums.Length - 1);
                finalResult = condensed[0];
            }
            Console.WriteLine(finalResult);
        }
    }
}
