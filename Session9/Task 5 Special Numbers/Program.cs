using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecial = false;

            for (int i = 1; i <= n; i++)
            {
                while (i > 0)
                {
                    sum += i % 10;
                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                        Console.WriteLine($"{i} -> False");
                    //n /= 10;
                }
                sum = sum / 10;
            }
        }
    }
}
//int num = int.parse(console.readline());
//int counter = num;
//int sumofdigits = 0;

//            while (num > 0)
//            {
//                sumofdigits = sumofdigits + num % 10;
//                num = num / 10;
//            }

//            for (int i = 1; i <= counter; i++)
//            {
//                if (sumofdigits == 5 || sumofdigits == 7 || sumofdigits == 11)
//                {
//                    console.writeline($"{i} -> true");
//                }
//                else
//                {
//                    console.writeline($"{i} -> false");
//                }
//            }
