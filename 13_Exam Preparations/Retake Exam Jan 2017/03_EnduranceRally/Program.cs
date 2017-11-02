using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EnduranceRally
{
    static void Main()
    {
        //input
        string driversNames = Console.ReadLine();
        string zones = Console.ReadLine();
        string checkpoints = Console.ReadLine();

        List<string> listOfDrivers = driversNames.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        double[] listOfZones = zones.Split(' ').Select(double.Parse).ToArray();
        List<int> checkpointIndexes = checkpoints.Split(' ').Select(int.Parse).ToList();

        //program

        Dictionary<string, double> driversFuel = new Dictionary<string, double>();

        foreach (var driver in listOfDrivers)
        {
            var fuel = (double)driver.First();
            var reached = -1; // or 0.... not sure

            for (int i = 0; i < listOfZones.Length; i++)
            {
                var zone = listOfZones[i];
                
                if (!IsCheckpiont(zone, checkpointIndexes, listOfZones))
                    fuel -= zone;
                else
                    fuel += zone;

                if (fuel <= 0)
                {
                    reached = i;
                    break;
                }
            }

            if (reached == -1)
            {
                Console.WriteLine($"{driver} - fuel left {fuel:F2}");
            }
            else
                Console.WriteLine($"{driver} - reached {reached}");
        }
    }

    private static bool IsCheckpiont(double zone, List<int> checkpointIndexes, double[] listOfZones)
    {
        if (checkpointIndexes.Contains(Array.IndexOf(listOfZones, zone)))
            return true;
        else
            return false;
    }
}

//List<int> initialFuels = new List<int>();
//        foreach (var driver in listOfDrivers)
//            initialFuels.Add((int) driver.First());

//        Dictionary<string, double> driversFuel = new Dictionary<string, double>();

//        for (int i = 0; i<listOfDrivers.Count; i++)
//        {
//            driversFuel.Add(listOfDrivers[i], initialFuels[i]);
//        }

//        foreach (var df in driversFuel)
//        {
//            for (int i = 0; i<listOfZones.Count; i++)
//            {
//                if (IsCheckpoint(listOfZones[i]))
//                    driversFuel[df.Key] += listOfZones[i];
//                else
//                    driversFuel[df.Key] -= listOfZones[i];
//            }
//        }

