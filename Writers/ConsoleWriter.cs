using System;
using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void WriteStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"\nName: {student.StudentName}\nKnowledge level: {student.GetKnowledgeLevel()}");
            }
        }
    }
}
