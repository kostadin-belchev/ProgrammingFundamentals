using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string proff = Console.ReadLine();
            int quant = int.Parse(Console.ReadLine());

            switch (proff)
            {
                case "Athlete":
                    double priceA = quant * 0.70;
                    Console.WriteLine($"The {proff} has to pay {priceA:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    double priceB = quant * 1.00;
                    Console.WriteLine($"The {proff} has to pay {priceB:F2}.");
                    break;
                case "SoftUni Student":
                    double priceS = quant * 1.70;
                    Console.WriteLine($"The {proff} has to pay {priceS:F2}.");
                    break;
                default:
                    double priceO = quant * 1.20;
                    Console.WriteLine($"The {proff} has to pay {priceO:F2}.");
                    break;
            }
        }
    }
}
