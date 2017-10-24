using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                double cubeFaceDiagonals = GetCubeFaceDiagonals(side);
                Console.WriteLine($"{cubeFaceDiagonals:F2}");
            }
            else if (parameter == "space")
            {
                double cubeSpaceDiagonals = GetCubeSpaceDiagonals(side);
                Console.WriteLine($"{cubeSpaceDiagonals:F2}");
            }
            else if (parameter == "volume")
            {
                double cubeVolume = GetCubeVolume(side);
                Console.WriteLine($"{cubeVolume:F2}");
            }
            else if (parameter == "area")
            {
                double cubeArea = GetCubeArea(side);
                Console.WriteLine($"{cubeArea:F2}");
            }
        }

        private static double GetCubeArea(double side)
        {
            return 6 * side * side;
        }

        private static double GetCubeVolume(double side)
        {
            return side * side * side;
        }

        private static double GetCubeSpaceDiagonals(double side)
        {
            return Math.Sqrt(3 * side * side);
        }

        private static double GetCubeFaceDiagonals(double side)
        {
            return Math.Sqrt(2 * side * side);
        }
    }
}
