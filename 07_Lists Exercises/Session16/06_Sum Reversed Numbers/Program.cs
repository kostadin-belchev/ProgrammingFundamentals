using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //long result = Console.ReadLine().Split().Select(a => long.Parse(new string(a.Reverse().ToArray()))).Sum();
            List<string> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            //Console.WriteLine(string.Join(" ", nums));

            List<int> results = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] = ReverseString(nums[i]);
            }

            //Console.WriteLine(string.Join(" ", nums));

            results = nums.Select(int.Parse).ToList();
            //Console.WriteLine(string.Join(" ", results));

            int sum = results.Sum();
            Console.WriteLine(sum);
        }

        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
