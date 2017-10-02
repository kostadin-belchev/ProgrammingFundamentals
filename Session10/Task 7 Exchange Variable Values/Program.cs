using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before: \na = {a}\nb = {b}");

            int temp = 0;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After: \na = {a}\nb = {b}");

        }
    }
}
