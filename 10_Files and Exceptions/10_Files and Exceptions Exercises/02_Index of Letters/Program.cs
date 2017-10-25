using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("input.txt");

            char[] input = text.ToArray();
            string[] output = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = $"{input[i]} -> {input[i] - 97}";
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
