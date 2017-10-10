using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(num, power));
        }

        private static double RaiseToPower(double n, double pow)
        {
            double numberToPower = 1;
            
            for (int i = 0; i < pow; i++)
            {
                numberToPower = numberToPower * n;
            }
            return numberToPower;
        }
    }
}
