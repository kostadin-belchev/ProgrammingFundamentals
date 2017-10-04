using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int sumofdigits = 0;
                int currentNumInteration = i;
                while (currentNumInteration > 0)
                {
                    sumofdigits = sumofdigits + currentNumInteration % 10;
                    currentNumInteration = currentNumInteration / 10;
                }

                if (sumofdigits == 5 || sumofdigits == 7 || sumofdigits == 11)
                {
                    Console.WriteLine($"{i} -> true");
                }
                else
                {
                    Console.WriteLine($"{i} -> false");
                }
            }
        }
    }
}
