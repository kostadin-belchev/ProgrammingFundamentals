using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());

            int totalNumberOfCombinations = 0;

            int lastFirstDigit = 0;
            int lastSecondDigit = 0;

            bool numFound = false;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    if (i + j == magicalNum)
                    {
                        lastFirstDigit = i;
                        lastSecondDigit = j;
                        numFound = true;
                    }
                    totalNumberOfCombinations++;
                }
            }
            if (numFound)
                Console.WriteLine($"Number found! {lastFirstDigit} + {lastSecondDigit} = {magicalNum}");
            else
            {
                Console.WriteLine($"{totalNumberOfCombinations} combinations - neither equals {magicalNum}");
            }
        }
    }
}
/*
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int lastFirstNumber = -1;
            int lastSecondNumber = -1;

            int count = 0;

            bool isFound = false;

            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = startNumber; j <= endNumber; j++)
                {
                    if (i + j == magicNumber)
                    {
                        lastFirstNumber = i;
                        lastSecondNumber = j;
                        isFound = true;
                    }
                    count++;
                }
            }

            if (isFound)
                Console.WriteLine($"Number found! {lastFirstNumber} + {lastSecondNumber} = {magicNumber}");
            else
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
*/
