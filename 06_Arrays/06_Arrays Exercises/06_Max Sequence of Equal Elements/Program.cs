using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 0;

            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputArray[i - 1])
                {
                    length++;
                    start = inputArray[i];
                }
                else
                {
                    length = 1;
                    start = inputArray[i];
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }

            List<int> resultToPrint = new List<int>();
            for (int i = 0; i < bestLength; i++)
            {
                resultToPrint.Add(bestStart);
            }
            Console.WriteLine(String.Join(" ", resultToPrint));
        
        }
    }
}
