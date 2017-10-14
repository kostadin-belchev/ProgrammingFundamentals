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

            int finalResult = 0;
            int intermittentResult;

           
            for (int i = 1; i < nums.Length; i++)
            {
                intermittentResult = nums[i -1] + (nums[i]);
                finalResult += intermittentResult;
            }


            Console.WriteLine(finalResult);
        }
    }
}
