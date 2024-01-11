using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using DataAccessLayer;

namespace BusinessLogic
{
    public class Logic
    {
        // private readonly IRepository<Student> _studentRepository = new StudentEntityRepository();
        // private readonly IRepository<Student> _studentRepository = new StudentDapperRepository();
        private readonly IRepository<Student> _studentRepository;

        public Logic(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void AddStudent(string name, string speciality, string group)
        {
            _studentRepository.Create(new Student
            {
                Name = name,
                Speciality = speciality,
                Group = group,
            });
        }

        public bool DeleteStudent(int id)
        {
            return _studentRepository.Delete(id);
        }

        public void FillStudents()
        {
            int baseSeed = DateTime.Now.Millisecond;

            for (int i = 0; i < 8; i++)
            {
                Student student = new Student();
                student.FillRandom(baseSeed * (100 + i));

                _studentRepository.Create(student);
            }
        }

        public List<Student> ShowTable()
        {
            return _studentRepository.Read();
        }

        public IEnumerable<IGrouping<string, Student>> ShowGist()
        {
            return _studentRepository.Read().GroupBy(student => student.Speciality);
        }
    }
}