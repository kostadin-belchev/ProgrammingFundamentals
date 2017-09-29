using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean numIsOdd = false;
            int num = -1;

            do
            {
                num = int.Parse(Console.ReadLine());
                if (Math.Abs(num % 2) == 1)
                    numIsOdd = true;
                else
                    Console.WriteLine("Please write an odd number.");
            } while (!numIsOdd);

            Console.WriteLine("The number is: " + Math.Abs(num));
        }
    }
}
//Console.WriteLine("Please write and odd numer.");