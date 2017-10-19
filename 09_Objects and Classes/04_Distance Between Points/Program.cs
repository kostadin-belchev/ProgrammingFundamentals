using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();


            Point p2 = ReadPoint();

            double distance = CalculatesDistance(p1, p2);

            Console.WriteLine($"{distance:F3}");

        }

        private static Point ReadPoint()
        {
            string[] p1Values = Console.ReadLine().Split();
            Point p1 = new Point();
            p1.X = int.Parse(p1Values[0]);
            p1.Y = int.Parse(p1Values[1]);
            return p1;
        }

        static double CalculatesDistance(Point point1, Point point2)
        {
            int deltaX = point1.X - point2.X;
            int deltaY = point1.Y - point2.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
