using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int empID = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            /*
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Employee ID: {0:D8}", empID);
            Console.WriteLine("Salary: {0:F2}", salary);
            */
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {empID:D8}");
            Console.WriteLine($"Salary: {salary:F2}");

        }
    }
}
