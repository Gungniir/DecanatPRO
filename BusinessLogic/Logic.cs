using Model;

namespace BusinessLogic
{
    public class Logic
    {
        private List<Student> Students { get; set; } = new();

        public void AddStudent(string name, string speciality, string group)
        {
            Students.Add(new Student
            {
                Name = name,
                Speciality = speciality,
                Group = group,
            });
        }

        public bool DeleteStudent(string name, string speciality, string group)
        {
            return Students.RemoveAll(student =>
                student.Name == name && student.Speciality == speciality && student.Group == group
            ) > 0;
        }

        public void FillStudents()
        {
            Students = new List<Student>();

            for (int i = 0; i < 8; i++)
            {
                Student student = new Student();
                student.FillRandom();

                Students.Add(student);
            }
        }

        public List<Student> ShowTable()
        {
            return Students;
        }

        public IEnumerable<IGrouping<string, Student>> ShowGist()
        {
            return Students.GroupBy(student => student.Speciality);
        }
    }
}