using System.Collections.Generic;
using System.Linq;
using Model;

namespace DataAccessLayer
{
    public class StudentEntityRepository: IRepository<Student>
    {
        private readonly EntityContext _db = new();

        public Student Create(Student entity)
        {
            entity = _db.Students.Add(entity);
            _db.SaveChanges();

            return entity;
        }

        public List<Student> Read()
        {
            return _db.Students.ToList();
        }

        public Student Update(Student entity)
        {
            Student student = _db.Students.SingleOrDefault(student => student.Id == entity.Id);

            if (student != null)
            {
                student.Name = entity.Name;
                student.Group = entity.Group;
                student.Speciality = entity.Speciality;
                _db.SaveChanges();

                return entity;
            }

            return null;
        }

        public bool Delete(Student entity)
        {
            return _db.Students.Remove(entity) != null;
        }
    }
}