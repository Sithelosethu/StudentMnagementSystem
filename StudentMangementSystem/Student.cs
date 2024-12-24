using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    // Student class to hold student information
    class Student
    {
        public int Id { get; set; }      // Student ID
        public string Name { get; set; } // Student Name
        public double[] Grades { get; set; } // Student Grades

        // Constructor to initialize a student object with name, id, and grades
        public Student(string name, int id, double[] grades)
        {
            Name = name;
            Id = id;
            Grades = grades;
        }

        // Method to calculate the average grade of the student
        public double CalculateAverage()
        {
            double sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }
            return sum / Grades.Length;
        }
    }
}