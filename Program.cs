using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using InternshipTest.Readers;
using InternshipTest.Writers;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Viktoriia Pavliuk");
            student1.SetKnowledge(new Knowledge(88));

            var student2 = new Student("Vitaliy Datsyshyn");
            student2.SetKnowledge(new Knowledge(89));

            var student3 = new Student("Petro Beckham");
            student3.SetKnowledge(new Knowledge(47));

            var student4 = new Student("Natalie Dormer");
            student4.SetKnowledge(new Knowledge(70));

            var LPNU = new University("LP NU");
            LPNU.AddStudent(student1);
            LPNU.AddStudent(student2);
            LPNU.AddStudent(student3);
            LPNU.AddStudent(student4);

            IReader reader = new ConsoleReader();

            LPNU.AddStudents(reader.ReadStudents());

            var internship = new Internship("InterLink");
            internship.AddStudentsFromUniversity(LPNU);

            IWriter writer = new ConsoleWriter();
            writer.WriteStudents(internship.GetStudents());
        }
    }
}
