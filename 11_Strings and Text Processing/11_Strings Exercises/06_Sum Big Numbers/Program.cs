using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06_Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigInt1 = BigInteger.Parse(Console.ReadLine());
            BigInteger bigInt2 = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = bigInt1 + bigInt2;

            Console.WriteLine(sum);
        }
    }
}
