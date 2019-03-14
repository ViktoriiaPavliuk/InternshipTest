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
            int studentsKnowledgeAmount = 0;
            List<Student> studentsFromUniversity = university.GetStudents();

            foreach (Student student in studentsFromUniversity)
            {
                studentsKnowledgeAmount += student.GetKnowledgeLevel();
            }

            int avaregeStudentKnowledge = studentsKnowledgeAmount / studentsFromUniversity.Count;

            foreach (Student student in studentsFromUniversity)
            {
                if (student.GetKnowledgeLevel() > avaregeStudentKnowledge)
                    _students.Add(student);
            }
        }

        public List<Student> GetStudents()
        {
            return _students;
        }
    }
}
