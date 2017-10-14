using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            if (IsPrime(number))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            
        }

        private static bool IsPrime(long num1)
        {
            if (num1 == 0 || num1 == 1)
            {
                return false;
            }
            else
            {
                for (long i = 2; i <= Math.Sqrt(num1); i++)
                {
                    if (num1 % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
