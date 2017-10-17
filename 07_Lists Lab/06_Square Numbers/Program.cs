using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> squareNums = new List<int>();

            foreach (var num in nums)
            {
                if (Math.Sqrt(num) == Math.Truncate(Math.Sqrt(num)))
                {
                    squareNums.Add(num);
                }
            }
            //Variant 1
            //squareNums.Sort();
            //squareNums.Reverse();
            //Console.WriteLine(string.Join(" ", squareNums));
            //variant 2
            squareNums.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
