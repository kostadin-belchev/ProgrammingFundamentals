using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int biggerNumber = -1;
            int smallNumber = -1;

            if (num1 > num2)
            {
                biggerNumber = num1;
                smallNumber = num2;
            }
            else
            {
                biggerNumber = num2;
                smallNumber = num1;
            }

            for (int i = smallNumber; i <= biggerNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
