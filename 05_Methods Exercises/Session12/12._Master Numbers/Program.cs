using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) % 7 == 0 && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int n)
        {
            while (n != 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
                n = n / 10;
            }
            return false;
            
        }

        private static long SumOfDigits(int n)
        {
            long sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        private static bool IsPalindrome(int num)
        {
            if (num < 0)
                return false;

            int div = 1;
            // find the divisor
            while (num / div >= 10)
                div *= 10;

            // any number less than 10 is a palindrome
            while (num != 0)
            {
                int leading = num / div;
                int trailing = num % 10;
                if (leading != trailing)
                    return false;

                // % with div gets rid of leading digit
                // dividing result by 10 gets rid of trailing digit
                num = (num % div) / 10;

                // got rid of 2 numbers, update div accordingly
                div /= 100;
            }
            return true;
        }
    }
}
