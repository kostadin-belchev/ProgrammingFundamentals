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

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++) //Same as  while (n-- > 0)
            {
                string[] commands = Console.ReadLine().Split();
                string name = commands[0];
                double[] grades = commands.Skip(1).Select(double.Parse).ToArray();
                
                students[i] = new Student { Name = name, Grades = grades};
            }

            List<Student> studentsAboveFive = students.Where(x => x.AverageGrade >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();

            //studentsAboveFive = studentsAboveFive.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();

            foreach (var student in studentsAboveFive)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }

        class Student
        {
            public string Name { get; set; }
            public double[] Grades { get; set; }
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
