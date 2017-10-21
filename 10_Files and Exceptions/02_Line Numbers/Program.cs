using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variatn 1
            //string[] lines = File.ReadAllLines("input.txt");
            //string[] numberedLines = new string[lines.Length];

            //for (int i = 0; i < numberedLines.Length; i++)
            //{
            //    numberedLines[i] = (i + 1) + ". " + lines[i];
            //}

            //File.WriteAllLines("output.txt", numberedLines);

            //Variant 2
            //string[] lines2 = File.ReadAllLines("input.txt").Select((line, index) => (index + 1) + ". " + line).ToArray();
            //File.WriteAllLines("output.txt", lines2);

            //Variatn 3
            string[] lines3 = File.ReadAllLines("input.txt").Select((line, index) => $"{index + 1}. {line}").ToArray();
            File.WriteAllLines("output.txt", lines3);
        }
    }
}
