using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Viktoriia Pavliuk");
            student1.SetKnowledge(new Knowledge(88));

            Student student2 = new Student("Vitaliy Datsyshyn");
            student2.SetKnowledge(new Knowledge(89));

            Student student3 = new Student("Petro Beckham");
            student3.SetKnowledge(new Knowledge(47));

            Student student4 = new Student("Natalie Dormer");
            student4.SetKnowledge(new Knowledge(70));


            University LPNU = new University("LP NU");
            LPNU.AddStudent(student1);
            LPNU.AddStudent(student2);
            LPNU.AddStudent(student3);
            LPNU.AddStudent(student4);

            Internship internship = new Internship("InterLink");
            internship.AddStudentsFromUniversity(LPNU);

            foreach (Student student in internship.GetStudents())
            {
                Console.WriteLine(student.StudentName);
            }

            Console.ReadKey();
        }
    }
}
