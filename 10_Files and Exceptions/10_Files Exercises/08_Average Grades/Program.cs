using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(File.ReadAllText("numberOfStudents.txt"));
            string[] input = File.ReadAllLines("input.txt");

            List<Student> students = new List<Student>();
            int indexer = 0;

            int studentsCount = int.Parse(input[indexer++]);

            for (int i = 0; i < studentsCount; i++) //Same as  while (n-- > 0)
            {
                string[] commands = input[indexer++].Split();
                string name = commands[0];
                double[] grades = commands.Skip(1).Select(double.Parse).ToArray();

                students.Add( new Student { Name = name, Grades = grades } );
            }

            List<Student> studentsAboveFive = students.Where(x => x.AverageGrade >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();

            //studentsAboveFive = studentsAboveFive.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();
            List<string> results = new List<string>();

            foreach (var student in studentsAboveFive)
            {
                results.Add($"{student.Name} -> {student.AverageGrade:F2}");
            }

            File.WriteAllLines("output.txt", results);
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
