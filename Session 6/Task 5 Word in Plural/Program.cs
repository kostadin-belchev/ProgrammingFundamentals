using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string wordToPlural = "";

            if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s")||word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
                Console.WriteLine(word + "es");

            else if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length -1, 1);
                Console.WriteLine(word + "ies");
            } else
                Console.WriteLine(word + "s");
        }
    }
}
