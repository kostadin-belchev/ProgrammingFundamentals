using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> threeNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> resultingArray = new List<int>();

            int num1SecondLine = threeNums[0];
            int num2SecondLine = threeNums[1];
            int num3SecondLine = threeNums[2];

            resultingArray = nums.Take(num1SecondLine).ToList();

            resultingArray.RemoveRange(0, num2SecondLine);

            
            if (resultingArray.Contains(num3SecondLine))
                Console.WriteLine("YES!");
            else
                Console.WriteLine("NO!");
        }
    }
}
