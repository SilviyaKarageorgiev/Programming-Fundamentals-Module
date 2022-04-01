using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Students
{

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] data = command.Split();
                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string homeTown = data[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown
                };
                students.Add(student);

                command = Console.ReadLine();
            }
            string town = Console.ReadLine();
            List<Student> filteredStudents = students.Where(s => s.HomeTown == town).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
