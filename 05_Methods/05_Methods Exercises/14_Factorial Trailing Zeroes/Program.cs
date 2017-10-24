using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14_Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //BigInteger factorial = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    factorial = factorial * i;
            //}
            Console.WriteLine(NumOfTrailingZeros(n));
        }

        private static int NumOfTrailingZeros(int factorial)
        {
            // Initialize result
            int count = 0;

            // Keep dividing n by powers of 5 and update count
            for (int i = 5; factorial / i >= 1; i *= 5)
                count += factorial / i;

            return count;
        }
    }
}
