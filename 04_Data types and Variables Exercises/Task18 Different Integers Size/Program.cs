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
            BigInteger bigNumber = new BigInteger();
            bigNumber = BigInteger.Parse(Console.ReadLine());


        }
    }
}
/*
             * bool isSByte = false;
            bool isByte = false;
            bool isShort = false;
            bool isUShort = false;
            bool isInt = false;
            bool isUInt = false;
            bool isLong = false;
            bool isULong = false;

            
            if (bigNumber <= -9223372036854775808 || bigNumber >= 9223372036854775807)
            {
                Console.WriteLine($"{bigNumber} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{bigNumber} can fit in:");
                if (bigNumber >= -128 && bigNumber <= 127)
                {
                    isSByte = true;
                    Console.WriteLine("* sbyte");
                }
                if (bigNumber >= 0 && bigNumber <= 255)
                {
                    isByte = true;
                    Console.WriteLine("* byte");
                }
                if (bigNumber >= -32768 && bigNumber <= 32767)
                {
                    Console.WriteLine("* short");
                    isShort = true;
                }
                if (bigNumber >= 0 && bigNumber <= 65535)
                {
                    isUShort = true;
                    Console.WriteLine("* ushort");
                }
                if (bigNumber >= -2147483648 && bigNumber <= 2147483647)
                {
                    isInt = true;
                    Console.WriteLine("* int");
                }
                if (bigNumber >= 0 && bigNumber <= 4294967295)
                {
                    isUInt = true;
                    Console.WriteLine("* uint");
                }
                if (bigNumber >= -9223372036854775808 && bigNumber <= 9223372036854775807)
                {
                    isLong = true;
                    Console.WriteLine("* long");
                }
            }
             * if (bigNumber >= 0 && bigNumber <= 18446744073709551615)
            {
                isULong = true;
                Console.WriteLine("* ulong");
            }*/
