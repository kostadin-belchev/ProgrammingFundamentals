using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());
            string[] dayNames = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine(dayNames[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
