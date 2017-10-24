using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(number)); 
        }

        private static int Fib(int n)
        {
            int a = 0, b = 1, currentFibNum = 0;

            if (n == 0)
            {
                return 1;
            }

            for (int i = 1; i <= n; i++)
            {
                currentFibNum = a + b;
                a = b;
                b = currentFibNum;
            }
            return currentFibNum;
        }
    }
}
