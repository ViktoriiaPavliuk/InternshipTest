using System;
using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Readers
{
    public class ConsoleReader : IReader
    {
        public List<Student> ReadStudents()
        {
            List<Student> students = new List<Student>();
            int choice = 1;

            while (choice == 1)
            {
                Console.Write("Enter student`s name: ");
                string name = Console.ReadLine();
                Student student = new Student(name);

                if (name != "" && name != " ")
                {
                    Console.Write($"Enter knowledge level of {name}: ");
                    int.TryParse(Console.ReadLine(), out int level);
                    student.SetKnowledge(new Knowledge(level));

                    students.Add(student);

                    Console.Write("If you want to add one more student - press 1, else press any key: ");
                    int.TryParse(Console.ReadLine(), out choice);
                }
                else
                {
                    Console.WriteLine("Incorrect name!");
                }
            }

            return students;
        }
    }
}
