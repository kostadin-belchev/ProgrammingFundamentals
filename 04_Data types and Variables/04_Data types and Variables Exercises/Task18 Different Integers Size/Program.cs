using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Task18_Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            //BigInteger bigNumber = new BigInteger();
            //bigNumber = BigInteger.Parse(Console.ReadLine());

            string n = Console.ReadLine();
            
            try
            {
                long num = long.Parse(n);

                Console.WriteLine($"{num} can fit in:");

                if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (num >= byte.MinValue && num <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (num >= short.MinValue && num <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (num >= ushort.MinValue && num <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (num >= int.MinValue && num <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (num >= uint.MinValue && num <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                if (num >= long.MinValue && num <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
            catch (Exception)
            {

                Console.WriteLine($"{n} can't fit in any type");
            }
        }
    }
}