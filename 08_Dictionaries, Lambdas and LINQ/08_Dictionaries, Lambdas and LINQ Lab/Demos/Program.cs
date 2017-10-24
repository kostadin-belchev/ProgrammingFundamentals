using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };

            int firstNum = nums.First(); // 1
            Console.WriteLine(firstNum);

            int lastOddNum = nums.Last(x => x % 2 == 1); // 5
            Console.WriteLine(lastOddNum);

            int singleNum = nums.Single(x => x == 4); // 4
            Console.WriteLine(singleNum);
        }
    }
}
