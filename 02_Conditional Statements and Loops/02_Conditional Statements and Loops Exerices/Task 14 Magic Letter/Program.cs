using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            string magicalLetter = Console.ReadLine();

            string currentCombination = "";

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        currentCombination = $"{i}{j}{k}";
                        if (!currentCombination.Contains(magicalLetter))
                            Console.Write(currentCombination + " ");
                    }
                }
            }
            
        }
    }
}

