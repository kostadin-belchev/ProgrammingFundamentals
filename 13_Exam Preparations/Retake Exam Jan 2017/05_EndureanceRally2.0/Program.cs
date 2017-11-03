using System;
using System.Collections.Generic;
using System.Linq;

class Player
{
    public string Name { get; set; }
    public double Fuel { get; set; }
    public int Zone { get; set; }
}

class EnduranceRally
{
    static void Main()
    {
        var inputNames = Console.ReadLine().Split();
        var zones = Console.ReadLine().Split().Select(double.Parse).ToList();
        var checkpoints = Console.ReadLine().Split().Select(int.Parse).ToList();
        var list = new List<Player>();

        for (int i = 0; i < inputNames.Length; i++)
        {
            var name = inputNames[i];
            var fuel = (int)(name[0]);
            var currPlayer = new Player { Name = name, Fuel = fuel, Zone = 0 };
            list.Add(currPlayer);
            for (int j = 0; j < zones.Count; j++)
            {
                if (currPlayer.Fuel <= 0)
                {
                    continue;
                }

                if (checkpoints.Contains(j))
                {
                    currPlayer.Fuel += zones[j];
                    currPlayer.Zone++;
                }
                else
                {
                    currPlayer.Fuel -= zones[j];
                    if (currPlayer.Fuel <= 0)
                    {
                        continue;
                    }
                    currPlayer.Zone++;
                }
            }
        }

        foreach (var player in list)
        {
            if (player.Fuel > 0)
            {
                Console.WriteLine($"{player.Name} - fuel left {player.Fuel:f2}");
            }
            else
            {
                Console.WriteLine($"{player.Name} - reached {player.Zone}");
            }
        }
    }
}
