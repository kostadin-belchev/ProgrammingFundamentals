using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();

            for (int i = 1; i < nums.Count; i++)
            {
                var currSum = nums[i - 1] + nums[i];

                if (nums[i - 1] == nums[i])
                {
                    nums[i] = currSum;
                    nums.RemoveAt(i - 1);
                    i = 0;
                }
            }
            
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
