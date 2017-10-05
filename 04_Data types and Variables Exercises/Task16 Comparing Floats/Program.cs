using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16_Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double floatNum1 = double.Parse(Console.ReadLine());
            double floatNum2 = double.Parse(Console.ReadLine());

            double diff = floatNum1 - floatNum2;
            if (diff < 0)
                diff = diff * (-1F);

            double eps = 0.000001F;

            if (diff > eps)
                Console.WriteLine("False");
            else
                Console.WriteLine("True");
        }
    }
}
