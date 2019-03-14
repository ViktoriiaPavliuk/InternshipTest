using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Writers
{
    public interface IWriter
    {
        void WriteStudents(List<Student> students);
    }
}
