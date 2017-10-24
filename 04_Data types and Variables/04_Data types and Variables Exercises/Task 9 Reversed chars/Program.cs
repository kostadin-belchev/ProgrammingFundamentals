using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());

            Console.WriteLine($"{char3}{char2}{char1}");
        }
    }
}
