using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Readers
{
    public interface IReader
    {
        List<Student> ReadStudents();
    }
}
