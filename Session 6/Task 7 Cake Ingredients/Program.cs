using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int ingredientCounter = 0;

            while (input != "Bake!")
            {
                input = Console.ReadLine();
                if (input == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {ingredientCounter} ingredients.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {input}.");
                    ingredientCounter++;
                }
            }
        }
    }
}
