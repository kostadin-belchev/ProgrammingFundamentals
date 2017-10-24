using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempInFahrenheit = double.Parse(Console.ReadLine());
            double tempInCelcius = 0d;

            tempInCelcius = FahrenheitToCelcius(tempInFahrenheit);

            Console.WriteLine($"{tempInCelcius:F2}");
        }

        private static double FahrenheitToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
