using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Printing header row
            PrintingLineOfDashes(2 * n);

            //Printing middlepart
            for (int i = 0; i < n - 2; i++)
            {
                PrintingMiddleRow(n);
                Console.WriteLine();
            }

            //Printing bottom row
            PrintingLineOfDashes(2 * n);
        }

        private static void PrintingMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n - 1; i++)
            {
                PrintVSymbol();
            }
            Console.Write('-');
        }

        private static void PrintVSymbol()
        {
            Console.Write("\\/");
        }

        private static void PrintingLineOfDashes(int count)
        {
            Console.WriteLine(new string('-', count));
        }
    }
}
