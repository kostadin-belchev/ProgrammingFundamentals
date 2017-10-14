using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] seq = new int[n];

            seq[0] = 1;
            for (int i = 1; i < n; i++)
            {
                for (int j = i - k; j < i - 1; j++)
                {
                    
                }
            }
        }
    }
}
