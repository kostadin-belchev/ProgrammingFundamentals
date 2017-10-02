using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCharIndex = int.Parse(Console.ReadLine());
            int lastCharIndex = int.Parse(Console.ReadLine());

            for (int i = firstCharIndex; i <= lastCharIndex; i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
        }
    }
}
