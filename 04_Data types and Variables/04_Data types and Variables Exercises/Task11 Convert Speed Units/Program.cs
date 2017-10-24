    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Task11_Convert_Speed_Units
    {
        class Program
        {
            static void Main(string[] args)
            {
                float distanceInMeters = float.Parse(Console.ReadLine());
                float hours = float.Parse(Console.ReadLine());
                float minutes = float.Parse(Console.ReadLine());
                float seconds = float.Parse(Console.ReadLine());

                float totalSeconds = hours * 3600 + minutes * 60 + seconds;
                float totalTimeInHours = totalSeconds / 3600;

                float speedInMetersPerSecond = distanceInMeters/totalSeconds;
                float speedInKmPerHour = distanceInMeters / 1000 / totalTimeInHours;
                float speedInMilesPerHours = distanceInMeters / 1609 / totalTimeInHours;

                Console.WriteLine($"{speedInMetersPerSecond}");
                Console.WriteLine($"{speedInKmPerHour}");
                Console.WriteLine($"{speedInMilesPerHours}");

            }
        }
    }
