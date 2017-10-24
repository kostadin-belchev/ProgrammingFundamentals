using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            //enterign range
            int n = int.Parse(Console.ReadLine());
            //initializing all numbers in a bool array
            bool[] primes = new bool[n + 1];
            //0 and 1 are not prime, so we assig the indexes 0 and 1 to be false
            primes[0] = primes[1] = false;

            for (int i = 2; i <= n; i++)
                primes[i] = true;

            for (int num = 1; num < primes.Length; num++)
                if (primes[num])
                    for (int multiplier = 2; multiplier * num <= n; multiplier++)
                        primes[multiplier * num] = false;

            for (int i = 0; i <= n; i++)
                if (primes[i])
                    Console.Write(i + " ");

            Console.WriteLine();
        }
    }
}
