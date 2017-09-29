using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int countOfCombinations = 0;
            int sumFromTheCombinations = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    if (sumFromTheCombinations > maxSum)
                        break;
                    sumFromTheCombinations += 3 * (i * j);
                    countOfCombinations++;
                }
            }
            if (sumFromTheCombinations >= maxSum)
            {
                Console.WriteLine($"{countOfCombinations} combinations");
                Console.WriteLine($"Sum: {sumFromTheCombinations} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{countOfCombinations} combinations");
                Console.WriteLine($"Sum: {sumFromTheCombinations}");
            }
        }
    }
}
