using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            string primesList = String.Join(", ", FindPrimesInRange(startNum, endNum).ToArray());
            Console.WriteLine(primesList);
        }



        private static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
                
            }
            return primes;
        }

        private static bool IsPrime(int num1)
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
