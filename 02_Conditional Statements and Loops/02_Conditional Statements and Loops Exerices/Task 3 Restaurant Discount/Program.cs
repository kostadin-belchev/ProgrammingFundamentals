using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double discount = 0;
            double totalPrice = 0;
            double totalPriceWithDiscount = 0;
            double pricePerPerson = 0;
            int packagePrice = 0;

            if (package == "Normal")
            {
                discount = 0.95;
                packagePrice = 500;
            }
            else if (package == "Gold")
            {
                discount = 0.90;
                packagePrice = 750;
            }
            else if (package == "Platinum")
            {
                discount = 0.85;
                packagePrice = 1000;
            }

            if (groupSize <= 50)
            {
                string hallName = "Small Hall";
                totalPrice = 2500 + packagePrice;
                totalPriceWithDiscount = totalPrice * discount;
                pricePerPerson = totalPriceWithDiscount / groupSize;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$"); 
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                string hallName = "Terrace";
                totalPrice = 5000 + packagePrice;
                totalPriceWithDiscount = totalPrice * discount;
                pricePerPerson = totalPriceWithDiscount / groupSize;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                string hallName = "Great Hall";
                totalPrice = 7500 + packagePrice;
                totalPriceWithDiscount = totalPrice * discount;
                pricePerPerson = totalPriceWithDiscount / groupSize;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if (groupSize > 120)
                Console.WriteLine("We do not have an appropriate hall.");
        }
    }
}
