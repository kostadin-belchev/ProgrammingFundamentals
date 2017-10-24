using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = ReadCircle();
            Circle c2 = ReadCircle();

            if (CirclesIntersect(c1, c2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        private static bool CirclesIntersect(Circle c1, Circle c2) //whatch out with the private
        {
            double distanceBetweenCircleCenters = DistanceBetweenPoints(c1.Center, c2.Center);
            if (distanceBetweenCircleCenters <= c1.Radius + c2.Radius)
                return true;
            else
                return false;
        }

        private static double DistanceBetweenPoints(Point p1, Point p2) //whatch out with the private
        {
            double sideX = p1.X - p2.X;
            double sideY = p1.Y - p2.Y;
            return Math.Sqrt(sideX*sideX + sideY * sideY);
        }

        public static Circle ReadCircle() //whatch out with the private
        {
            string[] input = Console.ReadLine().Split();
            return new Circle { Center = ReadPoint(int.Parse(input[0]), int.Parse(input[1])), Radius = int.Parse(input[2])};
        }

        private static Point ReadPoint(int x, int y)
        {
            return new Point { X = x, Y = y };
        }

        public class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }
        }
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
