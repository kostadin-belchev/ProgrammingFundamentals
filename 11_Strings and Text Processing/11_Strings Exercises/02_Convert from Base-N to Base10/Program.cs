using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02_Convert_from_Base_N_to_Base10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Trim().Split();
            int baseN = int.Parse(line[0]);
            char[] number = line[1].ToCharArray();
            BigInteger result = new BigInteger(0);
            
            if (baseN >= 2 && baseN <= 10)
            {
                for (int i = number.Length - 1, n = 0; i >= 0; i--, n++)
                {
                    BigInteger num = new BigInteger(char.GetNumericValue(number[n]));
                    BigInteger forSum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(baseN), i));
                    result += forSum;
                }

                Console.WriteLine(result.ToString());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
