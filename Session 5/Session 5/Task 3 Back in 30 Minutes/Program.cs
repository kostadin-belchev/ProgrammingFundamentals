using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursEntered = int.Parse(Console.ReadLine());
            int minutesEntered = int.Parse(Console.ReadLine());

            int totalMinutes = minutesEntered + 30;

            if (totalMinutes > 59)
            {
                hoursEntered++;
                totalMinutes -= 60;
            }
            if (hoursEntered > 23)
                hoursEntered -= 24;
                
            if (totalMinutes < 10)
                Console.WriteLine($"{hoursEntered}:{totalMinutes:D2}");
            else
             Console.WriteLine($"{hoursEntered}:{totalMinutes}");
            
        }
    }
}
