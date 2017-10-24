using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
/* Solution
 * string[] firstStringOfWords = Console.ReadLine().Split(' ').ToArray();
            string[] secondStringOfWords = Console.ReadLine().Split(' ').ToArray();

            int shorterArrayLenght = Math.Min(firstStringOfWords.Length, secondStringOfWords.Length);
            int longerArrayLenght = Math.Max(firstStringOfWords.Length, secondStringOfWords.Length);

            int rightCommonEnd = 0;
            int leftCommonEnd = 0;

            for (int i = 0; i < shorterArrayLenght; i++)
            {
                if (firstStringOfWords[i] == secondStringOfWords[i])
                {
                    leftCommonEnd++;
                }
            }

            for (int i = 0; i < shorterArrayLenght; i++)
            {
                if (firstStringOfWords[firstStringOfWords.Length - 1 - i] == secondStringOfWords[secondStringOfWords.Length - 1 - i])
                {
                    rightCommonEnd++;
                }
            }
            Console.WriteLine(Math.Max(rightCommonEnd, leftCommonEnd));
 */
