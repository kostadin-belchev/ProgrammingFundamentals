using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Theather_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            
            if (age >= 0 && age <= 18)
            {
                if (typeOfDay == "Weekday")
                    price = 12;
                else if (typeOfDay == "Weekend")
                    price = 15;
                else if (typeOfDay == "Holiday")
                    price = 5;
            }
            else if (age > 18 && age <= 64)
            {
                if (typeOfDay == "Weekday")
                    price = 18;
                else if (typeOfDay == "Weekend")
                    price = 20;
                else if (typeOfDay == "Holiday")
                    price = 12;
            }
            else if (age > 64 && age <= 122)
            {
                if (typeOfDay == "Weekday")
                    price = 12;
                else if (typeOfDay == "Weekend")
                    price = 15;
                else if (typeOfDay == "Holiday")
                    price = 10;
            }
            else
                price = -1;

            if (price != -1)
                Console.WriteLine($"{price}$");
            else
                Console.WriteLine("Error!");
            
        }
    }
}
