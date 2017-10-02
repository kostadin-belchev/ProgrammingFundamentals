using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hexNum, 16));
        }
    }
}
