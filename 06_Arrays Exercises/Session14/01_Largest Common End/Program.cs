using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstStringOfWords = Console.ReadLine().Split(' ').ToArray();
            string[] secondStringOfWords = Console.ReadLine().Split(' ').ToArray();

            int counterOfEqualElem = 0;

            int shorterArrayLenght = Math.Min(firstStringOfWords.Length, secondStringOfWords.Length);

            for (int i = 0; i < shorterArrayLenght; i++)
            {

            }
        }
    }
}
