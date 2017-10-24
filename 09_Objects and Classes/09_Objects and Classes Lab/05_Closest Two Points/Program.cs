using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                Point p = ReadPoint();
                points.Add(p);
            }

            double minDistance = double.MaxValue;
            Point closest1 = null; //if something is wrong with the program it should trow exeption when null
            Point closest2 = new Point();

            for (int p1Index = 0; p1Index < points.Count; p1Index++)
            {
                for (int p2Index = 0; p2Index < points.Count; p2Index++)
                {
                    if (p1Index != p2Index)
                    {
                        double currDistance = CalculatesDistance(points[p1Index], points[p2Index]);
                        if (currDistance < minDistance)
                        {
                            minDistance = currDistance;
                            closest1 = points[p1Index];
                            closest2 = points[p2Index];
                        }
                    }
                }
            }

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({closest1.X}, {closest1.Y})");
            Console.WriteLine($"({closest2.X}, {closest2.Y})");
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
