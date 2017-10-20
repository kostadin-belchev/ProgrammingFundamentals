using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n-- > 0) //Same as for(int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();

            }

        }

        class Student
        {
            string Name { get; set; }
            double[] Grades { get; set; }
            public double AverageGrade
            {
                get
                {
                    return Grades.Average();
                }
            }
        }
    }
}
