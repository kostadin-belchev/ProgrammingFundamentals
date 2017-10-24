using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            //First point
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            //Second point
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPointToCenter(x1, y1, x2, y2);
        }

        private static void PrintClosestPointToCenter(double x1, double y1, double x2, double y2)
        {
            if (PrintDistanceToCenter(x1, y1) < PrintDistanceToCenter(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if(PrintDistanceToCenter(x1, y1) > PrintDistanceToCenter(x2, y2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }

        private static double PrintDistanceToCenter(double x, double y)
        {
            double diagnonal = Math.Sqrt(x * x + y * y);
            return diagnonal;
        }
    }
}
