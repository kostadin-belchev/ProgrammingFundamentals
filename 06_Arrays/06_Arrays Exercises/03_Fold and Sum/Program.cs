using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int k = nums.Length / 4;
            
            int[] upperLeft = nums.Take(k).Reverse().ToArray();
            int[] upperRight = nums.Reverse().Take(k).ToArray();
            int[] upperRow = new int[2 * k];

            int[] sum = new int[2 * k];

            for (int i = 0; i < upperLeft.Length; i++)
                upperRow[i] = upperLeft[i];

            for (int i = 0; i < upperRight.Length; i++)
                upperRow[k + i] = upperRight[i];

            var middle = nums.Skip(k).Take(2 * k).ToArray();

            for (int i = 0; i < sum.Length; i++)
                sum[i] = middle[i] + upperRow[i];

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
