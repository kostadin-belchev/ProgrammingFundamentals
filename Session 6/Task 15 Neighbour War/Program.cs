using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15_Neighbour_War
{
    class Program
    {
        static void Main(string[] args)
        {
            int damageOfPesho = int.Parse(Console.ReadLine());
            int damageOfGosho = int.Parse(Console.ReadLine());
            int healthOfPesho = 100;
            int healthOfGosho = 100;

            string winner = "";

            int round = 1;

            bool somebodyIsDead = false;

            while (healthOfPesho > 0 & healthOfGosho > 0)
            {
                if (round % 2 == 1)
                {
                    healthOfGosho -= damageOfPesho;
                    if (healthOfGosho <= 0)
                    {
                        somebodyIsDead = true;
                        winner = "Pesho";
                        break;
                    }
                    
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthOfGosho} health.");
                }
                else
                {
                    healthOfPesho -= damageOfGosho;
                    if (healthOfPesho <= 0)
                    {
                        somebodyIsDead = true;
                        winner = "Gosho";
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthOfPesho} health.");
                }
                
                if (round % 3 == 0 && !somebodyIsDead)
                {
                    healthOfGosho += 10;
                    healthOfPesho += 10;
                }
                round++;
            }
            Console.WriteLine($"{winner} won in {round}th round.");
        }
    }
}
/*
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            int round = 0;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                round++;
                if (round%2 != 0)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else
                {
                    peshoHealth -= goshoDamage;

                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                if (round % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
                
            }
            */
