using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SinoTheWalker
{
    static void Main()
    {
        //input
        string leaveTime = Console.ReadLine();
        string[] leaveTimeTokens = leaveTime.Split(':').ToArray();
        int leaveHours = int.Parse(leaveTimeTokens[0]);
        int leaveMinutes = int.Parse(leaveTimeTokens[1]);
        int leaveSeconds = int.Parse(leaveTimeTokens[2]);

        int numberOfSteps = int.Parse(Console.ReadLine()) % 86400;

        int secondsPerEachStep = int.Parse(Console.ReadLine()) % 86400;

        //program
        long totalSeconsToAdd = numberOfSteps * secondsPerEachStep;

        long arriveSeconds = leaveSeconds + totalSeconsToAdd;
        long arriveMinutes = leaveMinutes;
        long arriveHours = leaveHours;

        while (arriveSeconds > 59)
        {
            arriveMinutes++;
            arriveSeconds -= 60;
        }
        //Console.WriteLine(arriveMinutes);
        while (arriveMinutes > 59)
        {
            arriveHours++;
            arriveMinutes -= 60;
        }
        //arriveHours %= 24;
        while (arriveHours > 23)
        {
            arriveHours -= 24;
        }

        //output
        Console.WriteLine($"Time Arrival: {arriveHours:D2}:{arriveMinutes:D2}:{arriveSeconds:D2}");
    }
}

//DateTime timeOfLeavingSoftUni = DateTime.Parse(Console.ReadLine());
////int step = int.Parse(Console.ReadLine()) % 86400;
////int seconds = int.Parse(Console.ReadLine()) % 86400;
////86400 секунди = 1 ден
////махаме цели дни, ако някой се прави на интересен да ни ги подава като вход
//int stepsTaken = int.Parse(Console.ReadLine()) % 86400;
//int stepsPerSec = int.Parse(Console.ReadLine()) % 86400;
//int timeInTravel = stepsTaken * stepsPerSec;
//DateTime result = timeOfLeavingSoftUni.AddSeconds(timeInTravel);
////Output
//Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);

