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
            List<int> items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> squareNums = new List<int>();

            foreach (var item in items)
            {
                int num = item;
                if (Math.Sqrt(num) == Math.Truncate(Math.Sqrt(num)))
                {
                    squareNums.Add(item);
                }
            }
            squareNums.Sort();
            squareNums.Reverse();
            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
