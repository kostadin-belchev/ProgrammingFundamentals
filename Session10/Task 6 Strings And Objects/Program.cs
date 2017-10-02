using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloString = "Hello";
            string worldString = "World";

            object object1 = helloString + " " + worldString;
            string string3 = (string)object1;

            Console.WriteLine(string3);
        }
    }
}
