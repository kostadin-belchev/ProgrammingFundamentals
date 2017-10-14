using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfLittleString = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            int n = arrayOfLittleString.Length;
            string valueOfCurrIndex = "";

            for (int i = 1; i <= n / 2; i++)
            {
                
                    valueOfCurrIndex = arrayOfLittleString[i - 1];
                    arrayOfLittleString[i - 1] = arrayOfLittleString[n - i];
                    arrayOfLittleString[n - i] = valueOfCurrIndex;

                //need to do: valueOfCurrIndex = arrayOfLittleString[0];
                //arrayOfLittleString[0] = arrayOfLittleString[n - 1];
                //arrayOfLittleString[n - 1] = valueOfCurrIndex; (n - 1) / 2
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arrayOfLittleString[i] + " ");
            }
        }
    }
}
//Shorter solution using .Reverse() method
//Array.Reverse(arrayOfLittleString);

//for (int i = 0; i < arrayOfLittleString.Length; i++)
//{
//    Console.Write(arrayOfLittleString[i] + " ");
//}
//Console.WriteLine();
