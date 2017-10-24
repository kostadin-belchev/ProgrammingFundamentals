using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            string currHealthString = new string('|', currHealth);
            string remHealthString = new string('.', (maxHealth - currHealth));
            Console.WriteLine("Health: |" + currHealthString + remHealthString + "|");

            string currEnergyString = new string('|', currEnergy);
            string remEnergyString = new string('.', (maxEnergy - currEnergy));
            Console.WriteLine("Energy: |" + currEnergyString + remEnergyString + "|");
        }
    }
}
