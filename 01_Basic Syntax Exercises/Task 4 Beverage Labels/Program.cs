using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int kCalPer100ml = int.Parse(Console.ReadLine());
            int gramsOfSugerPer100ml = int.Parse(Console.ReadLine());

            double kcal = kCalPer100ml * volume / 100.0;
            double sugers = gramsOfSugerPer100ml * volume / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal}kcal, {sugers}g sugars");
        }
    }
}
