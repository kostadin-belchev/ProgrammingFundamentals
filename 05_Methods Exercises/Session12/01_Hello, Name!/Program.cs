using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintName(input);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
    }
}
