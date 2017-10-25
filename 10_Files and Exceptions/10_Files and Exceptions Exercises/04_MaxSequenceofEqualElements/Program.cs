using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = File.ReadAllText("input.txt").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

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

            foreach (var item in resultToPrint)
            {
                File.WriteAllText("output.txt", String.Join(" ", resultToPrint));
            }
        }
    }
}
