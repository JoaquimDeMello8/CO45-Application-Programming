using System;
using System.Collections.Generic;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output and display application heading
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Student grade calculator by Joaquim De Mello");
            Console.WriteLine("--------------------------------------------");
            // Initialize list of students
            List<Student> students = new List<Student>();

            // Input a single mark for each student
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter mark for Student {i}: ");
                double mark = double.Parse(Console.ReadLine());
                students.Add(new Student(i, mark));
            }

            // Display list of students with their mark and grade
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Student marks and grades");
            Console.WriteLine("-------------------------");
            foreach (Student student in students)
            {
                Console.WriteLine($"Student {student.Id}: {student.Mark} - {student.Grade}");
            }

            // Calculate and display mean, minimum, and maximum marks
            double totalMarks = 0;
            double minimumMark = double.MaxValue;
            double maximumMark = double.MinValue;
            foreach (Student student in students)
            {
                totalMarks += student.Mark;
                if (student.Mark < minimumMark)
                {
                    minimumMark = student.Mark;
                }
                if (student.Mark > maximumMark)
                {
                    maximumMark = student.Mark;
                }
            }
            double meanMark = totalMarks / students.Count;
            Console.WriteLine($"\nMean Mark: {meanMark}\nMinimum Mark: {minimumMark}\nMaximum Mark: {maximumMark}");

            // Calculate and display grade profile
            Dictionary<string, int> gradeProfile = new Dictionary<string, int>();
            gradeProfile.Add("A", 0);
            gradeProfile.Add("B", 0);
            gradeProfile.Add("C", 0);
            gradeProfile.Add("D", 0);
            gradeProfile.Add("F", 0);
            foreach (Student student in students)
            {
                if (student.Grade == "A")
                {
                    gradeProfile["A"]++;
                }
                else if (student.Grade == "B")
                {
                    gradeProfile["B"]++;
                }
                else if (student.Grade == "C")
                {
                    gradeProfile["C"]++;
                }
                else if (student.Grade == "D")
                {
                    gradeProfile["D"]++;
                }
                else
                {
                    gradeProfile["F"]++;
                }
            }
            Console.WriteLine("\n-------------");
            Console.WriteLine("Grade Profile");
            Console.WriteLine("-------------");
            foreach (KeyValuePair<string, int> kvp in gradeProfile)
            {
                double percentage = (double)kvp.Value / students.Count * 100;
                Console.WriteLine($"{kvp.Key}: {percentage}%");
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public double Mark { get; set; }
        public string Grade { get; set; }

        public Student(int id, double mark)
        {
            Id = id;
            Mark = mark;
            Grade = CalculateGrade(mark);
        }

        private string CalculateGrade(double mark)
        {
            if (mark >= 70)
            {
                return "A";
            }
            else if (mark >= 60)
            {
                return "B";
            }
            else if (mark >= 50)
            {
                return "C";
            }
            else if (mark >= 40)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}