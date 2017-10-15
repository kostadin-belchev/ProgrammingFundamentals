using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int k = nums.Length / 4;

            int[] upperLeft = nums.Take(k).Reverse().ToArray();
            int[] upperRight = nums.Reverse().Take(k).ToArray();
            int[] row1 = upperLeft.Concat(upperRight).ToArray();
            int[] row2 = nums.Skip(k).Take(2 * k).ToArray();
            var sum = row1.Select((x, index) => x + row2[index]);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
