using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate =  DateTime.ParseExact(Console.ReadLine(), "d-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d-MM-yyyy", CultureInfo.InvariantCulture);

            long workingDaysCounter = 0;
            long holidaysCounter = 0;

            List<DateTime> daysBetweenStartAndEnd = new List<DateTime>();

            DateTime[] holidays = new DateTime[11];
            holidays[0] = DateTime.ParseExact("1-01-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[1] = DateTime.ParseExact("3-03-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[2] = DateTime.ParseExact("1-05-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[3] = DateTime.ParseExact("6-05-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[4] = DateTime.ParseExact("24-05-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[5] = DateTime.ParseExact("6-09-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[6] = DateTime.ParseExact("22-09-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[7] = DateTime.ParseExact("1-11-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[8] = DateTime.ParseExact("24-12-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[9] = DateTime.ParseExact("25-12-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[10] = DateTime.ParseExact("26-12-2016", "d-MM-yyyy", CultureInfo.InvariantCulture);
            //for (var day = startDate; day <= endDate; day = day.AddDays(1))
            //    daysBetweenStartAndEnd.Add(day);

            for (var day = startDate; day <= endDate; day = day.AddDays(1))
            {
                DateTime current = new DateTime(2016, day.Month, day.Day);
                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday || holidays.Contains(current))
                    holidaysCounter++;
                else
                    workingDaysCounter++;
            }

            Console.WriteLine(workingDaysCounter);
        }
    }
}
