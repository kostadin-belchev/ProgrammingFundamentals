using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("input.txt");

            int[] arrayOfInts = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            bool isThereSuchANumber = false;

            int magicNumber = -1;

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                int[] leftArray = arrayOfInts.Take(i).ToArray();
                int[] rightArray = arrayOfInts.Skip(i + 1).ToArray();

                if (leftArray.Sum() == rightArray.Sum())
                {
                    magicNumber = i;
                    isThereSuchANumber = true;
                    break;
                }
            }

            if (!isThereSuchANumber)
                File.WriteAllText("output.txt", "no");
            else
                File.WriteAllText("output.txt", magicNumber.ToString());
        }
    }
}
