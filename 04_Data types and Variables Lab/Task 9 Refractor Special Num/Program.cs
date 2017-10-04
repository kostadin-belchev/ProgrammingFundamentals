using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_Refractor_Special_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isSpecial = false;

            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int currentIterNum = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentIterNum} -> {isSpecial}");
                sum = 0;
                i = currentIterNum;
            }
        }
    }
}



