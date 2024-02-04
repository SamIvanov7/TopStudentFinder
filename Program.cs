using System;
using System.Collections.Generic;

namespace SolarPowerEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student("Vasya", "Vasilenko", 90.5),
                new Student("Gesha", "Smith", 85.3),
                new Student("Akakiy", "Akakievich", 92.7)
            };

            var topStudent = StudentCollection.FindTopStudent(students);

            Console.WriteLine("Student with the highest grade:");
            Console.WriteLine(topStudent != null ? topStudent.ToString() : "No students in list.");
        }
    }
}
