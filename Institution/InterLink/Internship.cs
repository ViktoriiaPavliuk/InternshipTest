using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string InternshipName { get; set; }

        private List<Student> _students = new List<Student>();

        public Internship(string name)
        {
            InternshipName = name;
        }

        public void AddStudentsFromUniversity(University university)
        {
            _students.AddRange(university.GetBestStudents());
        }

        public List<Student> GetStudents()
        {
            return _students;
        }
    }
}
