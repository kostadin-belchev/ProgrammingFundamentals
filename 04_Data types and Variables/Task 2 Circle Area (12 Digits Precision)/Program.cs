using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Circle_Area__12_Digits_Precision_
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine(Math.Round(area, 12));
        }
    }
}
