namespace InternshipTest.Person
{
    public class Student
    {
        public string StudentName { get; set; }

        private Knowledge _knowledge = new Knowledge(0);

        public Student(string name)
        {
            StudentName = name;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            _knowledge = knowledge;
        }

        public int GetKnowledgeLevel()
        {
            return _knowledge.GetKnowledgeLevel();
        }
    }
}