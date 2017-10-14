using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Line
            //First point
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            //Second point
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            //Second Line
            //First point
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            //Second point
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            bool firstLineLonger = false;
            bool secondLineLonger = false;

            if (MeasureDistanceBetweenPoints(x1, y1, x2, y2) > MeasureDistanceBetweenPoints(x3, y3, x4, y4))
            {
                firstLineLonger = true;
            }
            else if (MeasureDistanceBetweenPoints(x1, y1, x2, y2) < MeasureDistanceBetweenPoints(x3, y3, x4, y4))
            {
                secondLineLonger = true;
            }
            else
            {
                Console.Write($"({x1}, {y1})({x2}, {y2})");
            }

            if (firstLineLonger)
            {
                PrintsClosestPointToCenter(x1, y1, x2, y2);
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (secondLineLonger)
            {
                PrintsClosestPointToCenter(x3, y3, x4, y4);
                Console.WriteLine($"({x4}, {y4})");
            }
            
            
        }

        private static double MeasureDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1)* (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        private static void PrintsClosestPointToCenter(double x1, double y1, double x2, double y2)
        {
            if (ReturnsDistanceToCenter(x1, y1) < ReturnsDistanceToCenter(x2, y2))
            {
                Console.Write($"({x1}, {y1})");
            }
            else if (ReturnsDistanceToCenter(x1, y1) > ReturnsDistanceToCenter(x2, y2))
            {
                Console.Write($"({x2}, {y2})");
            }
            else
            {
                Console.Write($"({x1}, {y1})");
            }
        }

        private static double ReturnsDistanceToCenter(double x, double y)
        {
            double diagnonal = Math.Sqrt(x * x + y * y);
            return diagnonal;
        }
    }
}
