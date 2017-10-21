using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("lines.txt");
            List<string> oddLines = new List<string>();

            for (int i = 1; i < lines.Length; i+=2)
            {
                oddLines.Add(lines[i]);
            }

            File.WriteAllLines("odd-lines.txt", oddLines);
        }
    }
}
