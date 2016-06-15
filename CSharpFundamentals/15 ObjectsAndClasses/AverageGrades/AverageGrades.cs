using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get; set; }

        public static Student ReadGrades()
        {
            var grades = new List<double>();
            var input = Console.ReadLine().Split(' ');
            for (int j = 1; j < input.Length; j++)
            {
                grades.Add(double.Parse(input[j]));
            }
            var student = new Student() { Name = input[0], Grades = grades, AverageGrade = grades.Average() };

            return student;
        }
    }
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //List of all students
            var students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                students.Add(Student.ReadGrades());
            }

            //Print
            var s = students.OrderBy(x => x.Name).ThenBy(x => -x.AverageGrade).ToList();

            for (int i = 0; i < s.Count; i++)
            {
                if (s[i].AverageGrade >= 5)
                {
                    Console.WriteLine("{0} -> {1:f2}", s[i].Name, s[i].AverageGrade);
                }              
            }
        }
    }
}
