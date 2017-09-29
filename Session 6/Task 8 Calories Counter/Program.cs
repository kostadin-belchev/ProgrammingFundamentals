using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredientsNumber = int.Parse(Console.ReadLine());
            string input = "";
            int totalCaloriesAmount = 0;

            for (int i = 1; i <= ingredientsNumber; i++)
            {
                input = (Console.ReadLine()).ToLower();
                if (input == "cheese")
                    totalCaloriesAmount += 500;
                if (input == "tomato sauce")
                    totalCaloriesAmount += 150;
                if (input == "salami")
                    totalCaloriesAmount += 600;
                if (input == "pepper")
                    totalCaloriesAmount += 50;
            }
            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}
