using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numToConvert = int.Parse(Console.ReadLine());

            Console.WriteLine((Convert.ToString(numToConvert, 16)).ToUpper());
            Console.WriteLine(Convert.ToString(numToConvert, 2));
        }
    }
}
