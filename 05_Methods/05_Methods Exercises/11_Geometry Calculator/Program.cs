using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "triangle")
            {
                double sideOfTriangle = double.Parse(Console.ReadLine());
                double heightOfTriangle = double.Parse(Console.ReadLine());

                double triangleArea = GetTriangleArea(sideOfTriangle, heightOfTriangle);
                Console.WriteLine($"{triangleArea:F2}");
            }
            else if (figureType == "square")
            {
                double sideOfSquare = double.Parse(Console.ReadLine());

                double squareArea = GetSquareArea(sideOfSquare);
                Console.WriteLine($"{squareArea:F2}");
            }
            else if (figureType == "rectangle")
            {
                double widthOfRectangle = double.Parse(Console.ReadLine());
                double heightOfRectangle = double.Parse(Console.ReadLine());

                double areaOfRectangle = GetRectangleArea(widthOfRectangle, heightOfRectangle);
                Console.WriteLine($"{areaOfRectangle:F2}");
            }
            else if (figureType == "circle")
            {
                double radiusOfCircle = double.Parse(Console.ReadLine());

                double areaOfCircle = GetAreaOfCircle(radiusOfCircle);
                Console.WriteLine($"{areaOfCircle:F2}");
            }
        }

        private static double GetAreaOfCircle(double radiusOfCircle)
        {
            return Math.PI * radiusOfCircle * radiusOfCircle;
        }

        private static double GetRectangleArea(double widthOfRectangle, double heightOfRectangle)
        {
            return widthOfRectangle * heightOfRectangle;
        }

        private static double GetSquareArea(double sideOfSquare)
        {
            return sideOfSquare * sideOfSquare;
        }

        private static double GetTriangleArea(double sideOfTriangle, double heightOfTriangle)
        {
            return (sideOfTriangle * heightOfTriangle) / 2;
        }
    }
}
