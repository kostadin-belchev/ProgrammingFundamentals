using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlapsN = int.Parse(Console.ReadLine());
            double metersFor1000FlapsM = double.Parse(Console.ReadLine());
            int enduranceP = int.Parse(Console.ReadLine());

            double metersTraveled = (wingFlapsN / 1000D) * metersFor1000FlapsM;
            double intermTime = wingFlapsN / 100D;
            double secondsPassed = intermTime + (wingFlapsN / enduranceP) * 5D;

            Console.WriteLine($"{metersTraveled:F2} m.");
            Console.WriteLine($"{secondsPassed} s.");
        }
    }
}
