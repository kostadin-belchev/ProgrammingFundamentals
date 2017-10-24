using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
			//Boolean inValidInput = true;

			//while (inValidInput)
			//{
				try
				{
					int num = int.Parse(Console.ReadLine());
					Console.WriteLine("It is a number.");
					//inValidInput = false;
				}
				catch (FormatException)
				{
					//inValidInput = true;
					Console.WriteLine("Invalid input!");
				}
			//}
            
            
        }
    }
}
