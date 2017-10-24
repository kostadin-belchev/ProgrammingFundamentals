using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //upper part of triangle
            for (int i = 1; i <= n - 1; i++)
            {
                PrintLineWithNumbers(1, i);
            }

            //middle line
            PrintLineWithNumbers(1, n);

            //lower part of triangle

            for (int i = n - 1; i >= 1; i--)
            {
                PrintLineWithNumbers(1, i);
            }
        }

        private static void PrintLineWithNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
