using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Hotel_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPricePerNight = 0;
            double doublePricePerNight = 0;
            double suitePricePerNight = 0;
            int studioNightsCount = nightsCount;

            switch (month)
            {
                case "May":
                case "October":
                    studioPricePerNight = 50;
                    doublePricePerNight = 65;
                    suitePricePerNight = 75;
                    if (nightsCount > 7)
                    {
                        studioPricePerNight = studioPricePerNight * 0.95;
                        if (month == "October")
                            studioNightsCount--;
                    }
                    Console.WriteLine($"Studio: {(studioPricePerNight * studioNightsCount):F2} lv.");
                    Console.WriteLine($"Double: {(doublePricePerNight * nightsCount):F2} lv.");
                    Console.WriteLine($"Suite: {(suitePricePerNight * nightsCount):F2} lv.");
                    break;

                case "June":
                case "September":
                    studioPricePerNight = 60;
                    doublePricePerNight = 72;
                    suitePricePerNight = 82;
                    if (nightsCount > 14)
                        doublePricePerNight = doublePricePerNight * 0.90;
                    if (nightsCount > 7 && month == "September")
                        studioNightsCount--;

                    Console.WriteLine($"Studio: {(studioPricePerNight * studioNightsCount):F2} lv.");
                    Console.WriteLine($"Double: {(doublePricePerNight * nightsCount):F2} lv.");
                    Console.WriteLine($"Suite: {(suitePricePerNight * nightsCount):F2} lv.");
                    break;

                case "July":
                case "August":
                case "December":
                    studioPricePerNight = 68;
                    doublePricePerNight = 77;
                    suitePricePerNight = 89;
                    if (nightsCount > 14)
                        suitePricePerNight = suitePricePerNight * 0.85;

                    Console.WriteLine($"Studio: {(studioPricePerNight * studioNightsCount):F2} lv.");
                    Console.WriteLine($"Double: {(doublePricePerNight * nightsCount):F2} lv.");
                    Console.WriteLine($"Suite: {(suitePricePerNight * nightsCount):F2} lv.");
                    break;

                default:
                    break;
            }
        }
    }
}
