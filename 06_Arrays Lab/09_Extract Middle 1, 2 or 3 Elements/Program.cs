using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (n.Length == 1)
                Console.WriteLine($"{{ {n[0]} }}");
            else if (n.Length % 2 == 0)
            {
                 Console.WriteLine($"{{ {n[n.Length / 2 - 1]}, {n[n.Length/2]} }}");
            }
            else if (n.Length % 2 != 0)
            {
                Console.WriteLine($"{{ {n[n.Length / 2 - 1]}, {n[n.Length / 2]}, {n[n.Length/2 + 1]} }}");
            }
        }
    }
}
