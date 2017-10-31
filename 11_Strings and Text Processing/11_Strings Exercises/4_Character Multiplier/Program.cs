using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split();
            List<char> string1 = inputLine[0].ToList();
            List<char> string2 = inputLine[1].ToList();

            long sum = SumOfMultipliedCharCodes(string1, string2);
            Console.WriteLine(sum);
        }

        private static long SumOfMultipliedCharCodes(List<char> str1, List<char> str2)
        {
            var result = str1.Zip(str2, (a, b) => (a * b));
            int sum = result.Sum();

            if (str1.Count > str2.Count)
            {
                int additionalSum = str1.Skip(str2.Count).Select(e => (int) e).Sum();
                sum += additionalSum;
            }
            else if (str1.Count < str2.Count)
            {
                int additionalSum = str2.Skip(str1.Count).Select(e => (int)e).Sum();
                sum += additionalSum;
            }
            
            return sum;
        }
    }
}
//static void Main(string[] args)
//{
//    string[] inputLine = Console.ReadLine().Split();
//    List<char> string1 = inputLine[0].ToList();
//    List<char> string2 = inputLine[1].ToList();

//    //var result = string1.Zip(string2, (a, b) => (a * b));
//    //int sum1 = result.Sum();

//    long sum = SumOfMultipliedCharCodes(string1, string2);
//    Console.WriteLine(sum);
//}

//private static long SumOfMultipliedCharCodes(List<char> str1, List<char> str2)
//{
//    long lenghtOfShorter = 0;
//    long diff = str1.Count - str2.Count;

//    if (diff >= 0)
//        lenghtOfShorter = str2.Count;
//    else
//        lenghtOfShorter = str1.Count;

//    long sum = 0;
//    for (int i = 0; i < lenghtOfShorter; i++)
//    {
//        sum += (long)str1[i] * (long)str2[i];
//    }

//    if (diff > 0)
//    {
//        for (int i = 0; i < diff; i++)
//            sum += str1[i];
//    }
//    else if (diff < 0)
//    {
//        for (int i = 0; i < Math.Abs(diff); i++)
//            sum += str2[i];
//    }

//    return sum;
//}
