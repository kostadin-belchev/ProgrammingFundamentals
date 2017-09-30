using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            //double cources = 0.0;

            //cources = n / p;
            //if (n % p != 0)
            //{
            //    cources++;
            //}
            //Console.WriteLine(Math.Round(cources));

            int cources =  (int) Math.Ceiling((double) n / p);
            Console.WriteLine(cources);
        }
    }
}
