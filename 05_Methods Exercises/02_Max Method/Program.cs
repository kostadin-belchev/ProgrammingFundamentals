using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(num1, GetMax(num2, num3)));

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
    }
}
