using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var brother1 = double.Parse(Console.ReadLine());
            var brother2 = double.Parse(Console.ReadLine());
            var brother3 = double.Parse(Console.ReadLine());
            var fatherFishing = double.Parse(Console.ReadLine());
            var cleaningTime = 1 / (1 / brother1 + 1 / brother2 + 1 / brother3);
            var bBreak = cleaningTime * 0.15;
            var timeWithBreak = cleaningTime + bBreak;
            var timeLeft = fatherFishing - timeWithBreak;

            Console.WriteLine($"Cleaning time: {timeWithBreak:f2}");


            if (timeLeft >= 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Truncate(timeLeft)} hours.");
            }
            else
            {
                timeLeft = timeLeft * -1;
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(timeLeft)} hours.");
            }
        }
    }
}
