using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetProductOfEvensAndOdds(number));
        }

        private static int GetProductOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(Math.Abs(n));
            int sumOdds = GetSumOfOddDigits(Math.Abs(n));

            return sumEvens * sumOdds;
        }

        private static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum = sum + lastDigit;
                }
                n = n / 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum = sum + lastDigit;
                }
                n = n / 10;
            }
            return sum;
        }
    }
}
