
using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    // Program class to handle user input and control the program flow
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(); // List to hold student objects
            string anotherStudent;

            do
            {
                // Collect student name
                Console.WriteLine("Enter name of student: ");
                string name = Console.ReadLine();

                // Collect student id with validation
                int id;
                Console.WriteLine("Enter student id: ");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Invalid input. Please enter a valid student ID:");
                }

                // Define an array for student grades (7 subjects)
                double[] grades = new double[7];
                string[] subjects = { "Math", "Life Sciences", "English", "Life Orientation", "Physical Sciences", "Accounting", "Zulu" };

                // Collect grades for each subject with validation
                Console.WriteLine("Enter the student's grades: ");
                for (int i = 0; i < grades.Length; i++)
                {
                    Console.WriteLine($"{subjects[i]}:");
                    while (!double.TryParse(Console.ReadLine(), out grades[i]))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid grade for " + subjects[i] + ":");
                    }
                }

                // Create a new student object and add it to the list
                Student student = new Student(name, id, grades);
                students.Add(student);

                // Ask if the user wants to add another student
                Console.WriteLine("Do you want to add another student? yes or no");
                anotherStudent = Console.ReadLine().ToLower();

            } while (anotherStudent == "yes");

            // Display all students and their average grades
            Console.WriteLine("\nDisplaying all students: ");
            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.Name}, ID: {student.Id}, Average Grade: {student.CalculateAverage():F2}");
            }
        }
    }
}

