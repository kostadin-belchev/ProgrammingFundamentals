using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfValue = Console.ReadLine();
            //Console.WriteLine(GetMax(Console.ReadLine(), Console.ReadLine()));

            if (typeOfValue == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (typeOfValue == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (typeOfValue == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }
        }

        private static int GetMax(int first, int second)
        {
            int max = 0;
            if (first >= second)
                max = first;
            else
                max = second;

            return max;
        }

        private static char GetMax(char first, char second)
        {
            char max = 'a';
            if (first >= second)
                max = first;
            else
                max = second;

            return max;
        }

        private static string GetMax(string first, string second)
        {
            string max = "";
            if (first.CompareTo(second) >= 0)
                max = first;
            else
                max = second;

            return max;
        }
    }
}
