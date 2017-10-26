using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("input.txt");

            int[] listOfNumbers = text.Split().Select(int.Parse).ToArray();

            int mostFreqNumber = 0;
            int longestSeqOfNumbers = 0;

            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < listOfNumbers.Length; j++)
                {
                    if (listOfNumbers[i] == listOfNumbers[j])
                    {
                        counter++;

                        if (counter > longestSeqOfNumbers)
                        {
                            longestSeqOfNumbers = counter;
                            mostFreqNumber = listOfNumbers[j];
                        }
                    }
                }
            }

            File.WriteAllText("output.txt", mostFreqNumber.ToString());
        }
    }
}
